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
using System.Reflection;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    internal class TestExecutor<TRequest, TResponse> where TRequest : class, new()
    {
        public TestExecutor(string methodName, string invalidPropertyName)
        {
            m_methodName = methodName;
            m_invalidPropertyName = invalidPropertyName;
        }

        public TRequest PrepareRequest()
        {
            TRequest request = CreateRequestInstance<TRequest>();
            InitFiles();
            return request;
        }

        public virtual void AssertResult(TResponse response)
        {
            if (m_invalidPropertyName == null)
            {
                Assert.IsNotNull(response);
            }
            else
            {
                foreach (OKToNotFailRule rule in EnumerateRules(Rules.OKToNotFail, m_invalidPropertyName))
                {
                    return;
                }
                if (ExpectedCode == 404)
                {
                    Assert.IsNull(response);
                }
                else
                {
                    Assert.Fail("Must have failed");
                }
            }
        }

        public void AssertException(Exception exception)
        {
            if (m_invalidPropertyName == null)
            {
                throw exception;
            }
            Assert.IsInstanceOf<ApiException>(exception);
            Assert.AreEqual(ExpectedCode, ((ApiException)exception).ErrorCode);
            Assert.IsTrue(exception.Message.Contains(ExpectedMessage));
        }

        private readonly string m_methodName;
        private readonly string m_invalidPropertyName;

        private object m_invalidPropertyValue;

        private static TestRules s_rules;
        private static TestRules Rules
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

        private int m_expectedCode;
        private string m_expectedMessage;

        private int ExpectedCode
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
            foreach (ResultRule rule in EnumerateRules(Rules.Results, m_invalidPropertyName))
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

        private T CreateRequestInstance<T>() where T : class, new()
        {
            T instance = new T();
            foreach (PropertyInfo propertyInfo in instance.GetType().GetProperties())
            {
                if (propertyInfo.CanWrite)
                {
                    object value = GetPropertyValue(propertyInfo);
                    if (value != null)
                    {
                        if (propertyInfo.PropertyType == typeof(Stream))
                        {
                            value = File.OpenRead(TestUtils.TestDataPath + "\\test.ppt");
                        }
                        else if (value.GetType() != propertyInfo.PropertyType)
                        {
                            JArray jArrayValue = value as JArray;
                            if (jArrayValue != null)
                            {
                                value = jArrayValue.ToObject(propertyInfo.PropertyType);
                            }
                            else
                            {
                                JObject jObjectValue = value as JObject;
                                if (jObjectValue != null)
                                {
                                    value = jObjectValue.ToObject(propertyInfo.PropertyType);
                                }
                                else
                                {
                                    Type notNullableType = Nullable.GetUnderlyingType(propertyInfo.PropertyType);
                                    if (notNullableType != null)
                                    {
                                        value = ConvertToSimpleType(value, notNullableType);
                                    }
                                    else
                                    {
                                        value = ConvertToSimpleType(value, propertyInfo.PropertyType);
                                    }
                                }
                            }
                        }
                        propertyInfo.SetValue(instance, value);
                    }
                }
            }
            return instance;
        }

        private object ConvertToSimpleType(object value, Type type)
        {
            if (type.IsEnum)
            {
                return Enum.Parse(type, (string)value, true);
            }
            return Convert.ChangeType(value, type);
        }

        private object GetPropertyValue(PropertyInfo propertyInfo)
        {
            object value = "test" + propertyInfo.Name;
            object invalidValue = null;
            foreach (ValueRule rule in EnumerateRules(Rules.Values, propertyInfo.Name))
            {
                if (rule.IsValueSet)
                {
                    value = rule.Value;
                }
                if (rule.IsInvalidValueSet)
                {
                    invalidValue = rule.InvalidValue;
                }
            }
            if (propertyInfo.Name.Equals(m_invalidPropertyName, StringComparison.InvariantCultureIgnoreCase))
            {
                m_invalidPropertyValue = Untemplatize(invalidValue, value);
                return m_invalidPropertyValue;
            }
            return value;
        }

        private IEnumerable<T> EnumerateRules<T>(IEnumerable<T> rules, string propertyName) where T : TestRule
        {
            foreach (T rule in rules)
            {
                if (Applies(rule, propertyName))
                {
                    yield return rule;
                }
            }
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
            foreach (FileRule rule in EnumerateRules(Rules.Files, m_invalidPropertyName))
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
