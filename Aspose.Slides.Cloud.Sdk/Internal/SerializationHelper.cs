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
    using System.Xml;
    using System.Xml.Serialization;
    using RequestHandlers;
    using Newtonsoft.Json.Linq;
    using System.Reflection;
    using System.Collections.Generic;

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

        public static object Deserialize(Stream content, string contentType, Type type)
        {
            //TODO: take content type from response
            if (contentType.Contains("xml"))
            {
                try
                {
                    try
                    {
                        return new XmlSerializer(type).Deserialize(content);
                    }
                    catch (Exception ex)
                    {
                        try
                        {
                            content.Position = 0;
                            using (StreamReader responseReader = new StreamReader(content))
                            {
                                return Deserialize(responseReader.ReadToEnd(), type);
                            }
                        }
                        catch
                        {
                            throw ex;
                        }
                    }
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
                    return Deserialize(responseReader.ReadToEnd(), type);
                }
            }
        }

        public static object Deserialize(string json, Type type)
        {
            if (type == typeof(string))
            {
                return json;
            }
            try
            {
                return JsonConvert.DeserializeObject(json, type, ModelConverter.Instance);
            }
            catch
            {
                if (type == typeof(ExceptionInfo))
                {
                    try
                    {
                        ErrorInfo error = (ErrorInfo)JsonConvert.DeserializeObject(json, typeof(ErrorInfo), ModelConverter.Instance);
                        return new ExceptionInfo { Message = error.Error };
                    }
                    catch
                    {
                        throw new ApiException(400, json);
                    }
                }
                throw new ApiException(400, json);
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
    }

    public class ModelConverter : JsonConverter
    {
        public static ModelConverter Instance { get { return s_instance ?? (s_instance = new ModelConverter()); } }

        public override bool CanConvert(Type objectType)
        {
            return objectType.Namespace == "Aspose.Slides.Cloud.Sdk.Model";
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JTokenReader jTokenReader = reader as JTokenReader;
            if (jTokenReader != null && jTokenReader.CurrentToken.Type == JTokenType.Null)
            {
                return null;
            }
            JsonTextReader jTextReader = reader as JsonTextReader;
            if (jTextReader != null && jTextReader.TokenType == JsonToken.Null)
            {
                return null;
            }
            JObject jObject = JObject.Load(reader);
            Dictionary<string, object> jProperties = new Dictionary<string, object>(
                jObject.ToObject<IDictionary<string, object>>(), StringComparer.CurrentCultureIgnoreCase);
            object target = Activator.CreateInstance(GetObjectType(objectType, jProperties));
            if (target != null)
            {
                serializer.Populate(jObject.CreateReader(), target);
            }
            return target;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        private Type GetObjectType(Type objectType, Dictionary<string, object> jProperties)
        {
            foreach (Type type in objectType.Assembly.GetTypes())
            {
                if (objectType.IsAssignableFrom(type) && IsJObjectOfType(jProperties, type))
                {
                    return type;
                }
            }
            return objectType;
        }

        private bool IsJObjectOfType(Dictionary<string, object> jProperties, Type type)
        {
            PropertyInfo typeDeterminersInfo = type.GetProperty("TypeDeterminers");
            if (typeDeterminersInfo != null)
            {
                Dictionary<string, object> typeDeterminers = (Dictionary<string, object>)typeDeterminersInfo.GetValue(null, null);
                if (typeDeterminers != null && typeDeterminers.Count > 0)
                {
                    foreach (string key in typeDeterminers.Keys)
                    {
                        if (!jProperties.ContainsKey(key) || jProperties[key] == null)
                        {
                            return false;
                        }
                        if (jProperties[key].ToString().ToLower() != typeDeterminers[key].ToString().ToLower())
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        private static ModelConverter s_instance;
    }
}