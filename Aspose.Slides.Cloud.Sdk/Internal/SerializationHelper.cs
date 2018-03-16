// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="SerializationHelper.cs">
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

namespace Aspose.Slides.Cloud.Sdk
{
    using System;
    using System.IO;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Xml;
    using System.Xml.Serialization;
    using RequestHandlers;

    internal class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            string contentType;
            return Serialize(obj, out contentType);
        }

        public static string Serialize(object obj, out string contentType)
        {
            try
            {
                contentType = "application/json";
                string objString = obj as string;
                if (objString != null)
                {
                    if (IsXml(objString))
                    {
                        contentType = "text/xml";
                    }
                    return objString;
                }
                return obj != null
                    ? JsonConvert.SerializeObject(obj, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
                    : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static T Deserialize<T>(Stream content, string contentType)
        {
            //TODO: take content type from response
            if (contentType.Contains("xml"))
            {
                try
                {
                    return (T)new XmlSerializer(typeof(T)).Deserialize(content);
                }
                catch (InvalidOperationException ex)
                {
                    // TODO: a workaround to fix wrong return code
                    try
                    {
                        content.Position = 0;
                        ExceptionInfo exceptionInfo = (ExceptionInfo)new XmlSerializer(typeof(ExceptionInfo)).Deserialize(content);
                        throw new ApiException(500, exceptionInfo.Message);
                    }
                    catch (ApiException)
                    {
                        throw;
                    }
                    catch
                    {
                        throw ex;
                    }
                }
                catch (Exception ex)
                {
                    throw new ApiException(500, ex.Message);
                }
            }
            else
            {
                using (StreamReader responseReader = new StreamReader(content))
                {
                    return Deserialize<T>(responseReader.ReadToEnd());
                }
            }
        }

        public static T Deserialize<T>(string json)
        {
            try
            {
                 return (T)JsonConvert.DeserializeObject(json, typeof(T));
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        private static bool IsXml(string source)
        {
            try
            {
                using (StringReader sourceReader = new StringReader(source))
                {
                    using (XmlReader xmlReader = XmlReader.Create(sourceReader))
                        xmlReader.Read();
                    return true;
                }
            }
            catch (XmlException)
            {
                return false;
            }
        }

        internal abstract class JsonCreationConverter<T> : JsonConverter
        {            
            public override bool CanConvert(Type objectType)
            {
                return typeof(T).IsAssignableFrom(objectType);
            }

            public override object ReadJson(
                JsonReader reader,
                Type objectType,
                object existingValue,
                JsonSerializer serializer)
            {
                var jsonObject = JObject.Load(reader);
                T target = this.Create(objectType, jsonObject);
                serializer.Populate(jsonObject.CreateReader(), target);
                return target;
            }

            public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            {
                serializer.Serialize(writer, value);
            }

            /// <summary>
            /// Create an instance of objectType, based properties in the JSON object.
            /// </summary>
            /// <param name="objectType">type of object expected.</param>
            /// <param name="jsonObject">
            /// Contents of JSON object that will be deserialized.
            /// </param>
            /// <returns>An instance of objectType.</returns>
            protected abstract T Create(Type objectType, JObject jsonObject);
        }
    }
}