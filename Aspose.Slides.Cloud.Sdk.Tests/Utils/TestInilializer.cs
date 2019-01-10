// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="TestInitializer.cs">
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

using Aspose.Slides.Cloud.Sdk.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Aspose.Slides.Cloud.Sdk.Tests.Utils
{
    internal class TestInitializer
    {
        public Type InvalidPropertyType { get; private set; }
        public virtual bool OKToFail { get { return false; } }
        public virtual bool OKToNotFail { get { return false; } }

        public TestInitializer(string invalidPropertyName)
        {
            m_invalidPropertyName = invalidPropertyName;
        }

        public static TestInitializer CreateInstance(string methodName, string invalidPropertyName)
        {
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.IsSubclassOf(typeof(TestInitializer)))
                {
                    object[] attributes = type.GetCustomAttributes(typeof(MethodAttribute), true);
                    foreach (object attribute in attributes)
                    {
                        if (((MethodAttribute)attribute).Name == methodName)
                        {
                            return (TestInitializer)Activator.CreateInstance(type, invalidPropertyName);
                        }
                    }
                }
            }
            return new TestInitializer(invalidPropertyName);
        }

        public virtual void Initialize()
        {
            if (m_invalidPropertyName != null && m_invalidPropertyName.Equals("name", StringComparison.InvariantCultureIgnoreCase))
            {
                TestUtils.DeleteFile(GetPath(Folder, "invalidValue" + GetName()));
            }
            TestUtils.Upload(GetName(), GetPath(Folder, GetName()));
        }

        public T CreateRequestInstance<T>() where T: class, new()
        {
            T instance = new T();
            foreach (PropertyInfo propertyInfo in instance.GetType().GetProperties())
            {
                if (propertyInfo.CanWrite)
                {
                    propertyInfo.SetValue(instance, GetPropertyValue(propertyInfo));
                }
            }
            return instance;
        }

        protected string GetPath(string folder, string name)
        {
            return (folder == null ? string.Empty : folder + "/") + name;
        }

        protected string Name { get { return "test.ppt"; } }

        protected string Folder { get { return "TempSlidesSDK"; } }

        protected virtual string GetName()
        {
            return Name;
        }

        protected virtual string GetPassword()
        {
            return "password";
        }

        protected virtual string GetFolder()
        {
            return Folder;
        }

        protected virtual string GetTemplatePath()
        {
            return Folder + "/" + Name;
        }

        protected virtual string GetFormat()
        {
            return "ppt";
        }

        protected virtual string GetShapePath()
        {
            return string.Empty;
        }

        protected virtual Stream GetStream()
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(GetStreamContent());
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        protected virtual string GetStreamContent()
        {
            return @"<staff>
    <person>  
        <name>John Doe</name>  
        <address><line1>10 Downing Street</line1><line2>London</line2></address>
        <phone>+457 123456</phone>
        <bio>Hi, I'm John and this is my CV</bio>
        <skills> 
            <skill><title>C#</title><level>Excellent</level></skill>
            <skill><title>C++</title><level>Good</level></skill>
            <skill><title>Java</title><level>Average</level></skill>
        </skills>
    </person>
</staff>";
        }

        private object GetPropertyValue(PropertyInfo propertyInfo)
        {
            object value = GetGoodPropertyValue(propertyInfo);
            if (propertyInfo.Name.Equals(m_invalidPropertyName, StringComparison.InvariantCultureIgnoreCase))
            {
                InvalidPropertyType = propertyInfo.PropertyType;
                return Invalidize(m_invalidPropertyName, value, propertyInfo.PropertyType);
            }
            else
            {
                return value;
            }
        }

        private object GetGoodPropertyValue(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType == typeof(string))
            {
                if (propertyInfo.Name.Equals("name", StringComparison.InvariantCultureIgnoreCase))
                {
                    return GetName();
                }
                if (propertyInfo.Name.Equals("folder", StringComparison.InvariantCultureIgnoreCase))
                {
                    return GetFolder();
                }
                if (propertyInfo.Name.Equals("templatePath", StringComparison.InvariantCultureIgnoreCase)
                    || propertyInfo.Name.Equals("source", StringComparison.InvariantCultureIgnoreCase)
                    || propertyInfo.Name.Equals("cloneFrom", StringComparison.InvariantCultureIgnoreCase))
                {
                    return GetTemplatePath();
                }
                if (propertyInfo.Name.EndsWith("storage", StringComparison.InvariantCultureIgnoreCase))
                {
                    return null;
                }
                if (propertyInfo.Name.Equals("format", StringComparison.InvariantCultureIgnoreCase))
                {
                    return GetFormat();
                }
                if (propertyInfo.Name.Equals("scaleType", StringComparison.InvariantCultureIgnoreCase))
                {
                    return "DoNotScale";
                }
                if (propertyInfo.Name.Equals("sizeType", StringComparison.InvariantCultureIgnoreCase))
                {
                    return "OnScreen";
                }
                if (propertyInfo.Name.Equals("propertyName", StringComparison.InvariantCultureIgnoreCase))
                {
                    return "testProperty";
                }
                if (propertyInfo.Name.Equals("color", StringComparison.InvariantCultureIgnoreCase))
                {
                    return "#FF0000dd";
                }
                if (propertyInfo.Name.Equals("shapePath", StringComparison.InvariantCultureIgnoreCase)
                    || propertyInfo.Name.Equals("path", StringComparison.InvariantCultureIgnoreCase))
                {
                    return GetShapePath();
                }
                if (propertyInfo.Name.EndsWith("password", StringComparison.InvariantCultureIgnoreCase))
                {
                    return GetPassword();
                }
                if (propertyInfo.Name.Equals("outPath", StringComparison.InvariantCultureIgnoreCase))
                {
                    return null;
                }
                if (propertyInfo.Name.Equals("data", StringComparison.InvariantCultureIgnoreCase))
                {
                    return GetStreamContent();
                }
                return propertyInfo.Name + Guid.NewGuid();
            }
            if (propertyInfo.PropertyType == typeof(Pipeline))
            {
                return new Pipeline();
            }
            if (propertyInfo.PropertyType == typeof(LayoutSlide))
            {
                return new LayoutSlide { MasterSlide = new ResourceUriElement { Uri = new ResourceUri { Href = "masterSlides/2" } } };
            }
            if (propertyInfo.PropertyType == typeof(Slide))
            {
                return new Slide { LayoutSlide = new ResourceUriElement { Uri = new ResourceUri { Href = "TitleOnly" } } };
            }
            if (propertyInfo.PropertyType == typeof(PresentationsMergeRequest))
            {
                return new PresentationsMergeRequest();
            }
            if (propertyInfo.PropertyType == typeof(OrderedMergeRequest))
            {
                return new OrderedMergeRequest();
            }
            if (propertyInfo.PropertyType == typeof(NotesSlide))
            {
                return new NotesSlide { Text = "testNote" };
            }
            if (propertyInfo.PropertyType == typeof(Paragraph))
            {
                return new Paragraph
                {
                    Alignment = TextAlignment.Left,
                    MarginLeft = 10,
                    SpaceAfter = 20
                };
            }
            if (propertyInfo.PropertyType == typeof(Portion))
            {
                return new Portion
                {
                    //TODO: fix error with forntColor
                    //FontColor = "FFFF0000",
                    FontHeight = 24,
                    Text = "testPortion"
                };
            }
            if (propertyInfo.PropertyType == typeof(DocumentProperties))
            {
                return new DocumentProperties { List = new List<DocumentProperty> { } };
            }
            if (propertyInfo.PropertyType == typeof(DocumentProperty))
            {
                return new DocumentProperty { Name = "testProperty001", Value = "testValue002" };
            }
            if (propertyInfo.PropertyType == typeof(ShapeBase) || propertyInfo.PropertyType == typeof(ResourceBase))
            {
                return new Shape
                {
                    Type = ShapeType.Shape,
                    ShapeType = CombinedShapeType.BentArrow,
                    GeometryShapeType = GeometryShapeType.Rectangle,
                    Text = "testShape"
                };
            }
            if (propertyInfo.PropertyType == typeof(Stream))
            {
                return GetStream();
            }
            if (propertyInfo.Name.Equals("shapeIndex", StringComparison.InvariantCultureIgnoreCase))
            {
                return 3;
            }
            if (propertyInfo.Name.EndsWith("index", StringComparison.InvariantCultureIgnoreCase)
                || propertyInfo.Name.EndsWith("position", StringComparison.InvariantCultureIgnoreCase)
                || propertyInfo.Name.Equals("slideToCopy", StringComparison.InvariantCultureIgnoreCase)
                || propertyInfo.Name.Equals("width", StringComparison.InvariantCultureIgnoreCase)
                || propertyInfo.Name.Equals("height", StringComparison.InvariantCultureIgnoreCase))
            {
                return 1;
            }
            if (propertyInfo.Name.Equals("oldPositions", StringComparison.InvariantCultureIgnoreCase))
            {
                return new List<int> { 1, 2 };
            }
            if (propertyInfo.Name.Equals("newPositions", StringComparison.InvariantCultureIgnoreCase))
            {
                return new List<int> { 2, 1 };
            }
            if (propertyInfo.PropertyType.IsValueType)
            {
                return Activator.CreateInstance(propertyInfo.PropertyType);
            }
            return null;
        }

        private object Invalidize(string fieldName, object value, Type type)
        {
            if (fieldName.Equals("path", StringComparison.InvariantCultureIgnoreCase))
            {
                return "45/shapes";
            }
            if (type == typeof(string))
            {
                if (fieldName.Equals("name", StringComparison.InvariantCultureIgnoreCase))
                {
                    return "invalidValue" + value;
                }
                return (string)value + "invalidValue";
            }
            if (type == typeof(int))
            {
                return 593;
            }
            if (type == typeof(List<int>))
            {
                return new List<int> { 593 };
            }
            if (type.IsEnum)
            {
                Array values = Enum.GetValues(type);
                return values.GetValue(RandomInstance.Next(values.Length));
            }
            return null;
        }

        private Random RandomInstance { get { return _random ?? (_random = new Random()); } }
        private Random _random;

        private readonly string m_invalidPropertyName;
    }
}
