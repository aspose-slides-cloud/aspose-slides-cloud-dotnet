// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestExecutor.cs">
//   Copyright (c) 2018 Aspose.Slides for Cloud
// </copyright>
// <summary>
//  Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
// 
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
// 
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    internal class VoidTestExecutor
    {
        public VoidTestExecutor(string methodName, string invalidPropertyName)
        {
            m_methodName = methodName;
            InvalidPropertyName = invalidPropertyName;
            InitFiles();
        }

        public T GetTestValue<T>(string name)
        {
            Type type = typeof(T);
            object value = GetParameterValue(name, ref type);
            if (value != null)
            {
                if (type == typeof(Stream))
                {
                    string fileName = "test.pptx";
                    if (m_methodName.Equals("ImportFromPdf", StringComparison.OrdinalIgnoreCase))
                    {
                        fileName = "test.pdf";
                    }
                    if (name.Equals("image", StringComparison.OrdinalIgnoreCase))
                    {
                        fileName = "watermark.png";
                    }
                    value = File.OpenRead(TestUtils.TestDataPath + "\\" + fileName);
                }
                else if (type == typeof(List<FileInfo>))
                {
                    value = new List<FileInfo>
                    {
                        new FileInfo { Name = "test.pptx", Content = File.OpenRead(TestUtils.TestDataPath + "\\test.pptx") },
                        new FileInfo { Name = "test-unprotected.pptx", Content = File.OpenRead(TestUtils.TestDataPath + "\\test-unprotected.pptx") }
                    };
                }
                else if (value.GetType() != type)
                {
                    JArray jArrayValue = value as JArray;
                    if (jArrayValue != null)
                    {
                        value = jArrayValue.ToObject(type);
                    }
                    else
                    {
                        JObject jObjectValue = value as JObject;
                        if (jObjectValue != null)
                        {
                            value = jObjectValue.ToObject(type);
                        }
                        else
                        {
                            Type notNullableType = Nullable.GetUnderlyingType(type);
                            if (notNullableType != null)
                            {
                                value = ConvertToSimpleType(value, notNullableType);
                            }
                            else
                            {
                                value = ConvertToSimpleType(value, type);
                            }
                        }
                    }
                }
            }
            return (T)value;
        }

        public void AssertResult()
        {
            if (InvalidPropertyName != null)
            {
                foreach (OKToNotFailRule rule in EnumerateRules(Rules.OKToNotFail, InvalidPropertyName))
                {
                    return;
                }
                Assert.Fail("Must have failed");
            }
        }

        public void AssertException(Exception exception)
        {
            if (InvalidPropertyName == null)
            {
                throw exception;
            }
            Assert.IsInstanceOf<ApiException>(exception);
            Assert.AreEqual(ExpectedCode, ((ApiException)exception).ErrorCode);
            Assert.IsTrue(exception.Message.Contains(ExpectedMessage));
        }

        protected int ExpectedCode
        {
            get
            {
                if (m_expectedCode == 0)
                {
                    SetExpectedResult();
                }
                return m_expectedCode;
            }
        }

        protected string InvalidPropertyName { get; private set; }

        protected IEnumerable<T> EnumerateRules<T>(IEnumerable<T> rules, string propertyName) where T : TestRule
        {
            foreach (T rule in rules)
            {
                if (Applies(rule, propertyName))
                {
                    yield return rule;
                }
            }
        }

        private static TestRules s_rules;
        protected static TestRules Rules
        {
            get
            {
                if (s_rules == null)
                {
                    using (StreamReader file = File.OpenText(@"../../../../TestRules.json"))
                    {
                        s_rules = (TestRules)new JsonSerializer().Deserialize(file, typeof(TestRules));
                    }
                }
                return s_rules;
            }
        }

        private readonly string m_methodName;

        private object m_invalidPropertyValue;

        private int m_expectedCode;
        private string m_expectedMessage;

        private string ExpectedMessage
        {
            get
            {
                if (m_expectedMessage == null)
                {
                    SetExpectedResult();
                }
                return m_expectedMessage ?? "Unspecified message";
            }
        }

        private void SetExpectedResult()
        {
            foreach (ResultRule rule in EnumerateRules(Rules.Results, InvalidPropertyName))
            {
                if (rule.Code.HasValue)
                {
                    m_expectedCode = rule.Code.Value;
                }
                if (rule.Message != null)
                {
                    m_expectedMessage = Untemplatize(rule.Message, m_invalidPropertyValue);
                }
            }
        }

        private object ConvertToSimpleType(object value, Type type)
        {
            if (type.IsEnum)
            {
                return Enum.Parse(type, (string)value, true);
            }
            return Convert.ChangeType(value, type);
        }

        public object GetParameterValue(string name, ref Type type)
        {
            object value = "test" + name;
            object invalidValue = null;
            foreach (ValueRule rule in EnumerateRules(Rules.Values, name))
            {
                if (rule.Type != null)
                {
                    Type ruleType = Type.GetType("Aspose.Slides.Cloud.Sdk.Model." + rule.Type + ", " + typeof(ApiBase).Assembly.GetName().Name);
                    if (!type.IsAssignableFrom(ruleType))
                    {
                        continue;
                    }
                    type = ruleType;
                }
                if (rule.IsValueSet)
                {
                    value = rule.Value;
                }
                if (rule.IsInvalidValueSet)
                {
                    invalidValue = rule.InvalidValue;
                }
            }
            if (name.Equals(InvalidPropertyName, StringComparison.InvariantCultureIgnoreCase))
            {
                m_invalidPropertyValue = Untemplatize(invalidValue, value);
                return m_invalidPropertyValue;
            }
            return value;
        }

        private bool Applies(TestRule rule, string propertyName)
        {
            return (rule.Method == null || rule.Method.Equals(m_methodName, StringComparison.OrdinalIgnoreCase))
                && (rule.Invalid == null || rule.Invalid == (propertyName != null))
                && (rule.Parameter == null || rule.Parameter.Equals(propertyName, StringComparison.OrdinalIgnoreCase))
                && (rule.Language == null || rule.Language.Equals("NET", StringComparison.OrdinalIgnoreCase));
        }

        private void InitFiles()
        {
            Dictionary<string, FileRule> rulesToApply = new Dictionary<string, FileRule>();
            if (InvalidPropertyName != null)
            {
                //necessary to fill m_invalidPropertyValue
                Type type = typeof(string);
                GetParameterValue(InvalidPropertyName, ref type);
            }
            foreach (FileRule rule in EnumerateRules(Rules.Files, InvalidPropertyName))
            {
                string actualName = Untemplatize(rule.File, m_invalidPropertyValue);
                string path = GetPath(Untemplatize(rule.Folder ?? "TempSlidesSDK", m_invalidPropertyValue), actualName);
                if (!rulesToApply.ContainsKey(path))
                {
                    rulesToApply.Add(path, rule);
                }
                else
                {
                    rulesToApply[path] = rule;
                }
                rulesToApply[path].ActualName = actualName;
            }
            foreach (string path in rulesToApply.Keys)
            {
                FileRule rule = rulesToApply[path];
                if (rule.Action == FileAction.Put)
                {
                    TestUtils.Upload(rule.ActualName, path);
                }
                else if (rule.Action == FileAction.Delete)
                {
                    TestUtils.DeleteFile(path);
                }
            }
        }

        private static string Untemplatize(string template, object value)
        {
            return template == null ? null : template.Replace("%v", value == null ? string.Empty : value.ToString());
        }

        private static object Untemplatize(object template, object value)
        {
            return template == null
                ? null
                : template is string ? ((string)template).Replace("%v", value == null ? string.Empty : value.ToString()) : template;
        }

        private string GetPath(string folder, string name)
        {
            return (folder == null ? string.Empty : folder + "/") + name;
        }
    }
}
