// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PictureFill.cs">
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

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Xml.Serialization;

namespace Aspose.Slides.Cloud.Sdk.Model
{
    /// <summary>
    /// Picture fill.
    /// </summary>  
    public class PictureFill : FillFormat 
    {                       
        /// <summary>
        /// The way texture is aligned within the shape. This setting controls the starting point of the texture pattern and how it repeats across the shape.
        /// </summary>
        /// <value>The way texture is aligned within the shape. This setting controls the starting point of the texture pattern and how it repeats across the shape.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TileAlignmentEnum
        {
            
            /// <summary>
            /// Enum TopLeft for "TopLeft"
            /// </summary>
            TopLeft,
            
            /// <summary>
            /// Enum Top for "Top"
            /// </summary>
            Top,
            
            /// <summary>
            /// Enum TopRight for "TopRight"
            /// </summary>
            TopRight,
            
            /// <summary>
            /// Enum Left for "Left"
            /// </summary>
            Left,
            
            /// <summary>
            /// Enum Center for "Center"
            /// </summary>
            Center,
            
            /// <summary>
            /// Enum Right for "Right"
            /// </summary>
            Right,
            
            /// <summary>
            /// Enum BottomLeft for "BottomLeft"
            /// </summary>
            BottomLeft,
            
            /// <summary>
            /// Enum Bottom for "Bottom"
            /// </summary>
            Bottom,
            
            /// <summary>
            /// Enum BottomRight for "BottomRight"
            /// </summary>
            BottomRight,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Flips the texture tile around its horizontal, vertical or both axis.
        /// </summary>
        /// <value>Flips the texture tile around its horizontal, vertical or both axis.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TileFlipEnum
        {
            
            /// <summary>
            /// Enum NoFlip for "NoFlip"
            /// </summary>
            NoFlip,
            
            /// <summary>
            /// Enum FlipX for "FlipX"
            /// </summary>
            FlipX,
            
            /// <summary>
            /// Enum FlipY for "FlipY"
            /// </summary>
            FlipY,
            
            /// <summary>
            /// Enum FlipBoth for "FlipBoth"
            /// </summary>
            FlipBoth,
            
            /// <summary>
            /// Enum NotDefined for "NotDefined"
            /// </summary>
            NotDefined
        }

        /// <summary>
        /// Fill mode.
        /// </summary>
        /// <value>Fill mode.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PictureFillModeEnum
        {
            
            /// <summary>
            /// Enum Tile for "Tile"
            /// </summary>
            Tile,
            
            /// <summary>
            /// Enum Stretch for "Stretch"
            /// </summary>
            Stretch
        }

        /// <summary>
        /// The way texture is aligned within the shape. This setting controls the starting point of the texture pattern and how it repeats across the shape.
        /// </summary>
        public TileAlignmentEnum? TileAlignment { get; set; }

        /// <summary>
        /// Flips the texture tile around its horizontal, vertical or both axis.
        /// </summary>
        public TileFlipEnum? TileFlip { get; set; }

        /// <summary>
        /// Fill mode.
        /// </summary>
        public PictureFillModeEnum? PictureFillMode { get; set; }

        /// <summary>
        /// Percentage of image height that is cropped from the bottom.
        /// </summary>
        public double? CropBottom { get; set; }

        /// <summary>
        /// Percentage of image height that is cropped from the left.
        /// </summary>
        public double? CropLeft { get; set; }

        /// <summary>
        /// Percentage of image height that is cropped from the right.
        /// </summary>
        public double? CropRight { get; set; }

        /// <summary>
        /// Percentage of image height that is cropped from the top.
        /// </summary>
        public double? CropTop { get; set; }

        /// <summary>
        /// Picture resolution.
        /// </summary>
        public int? Dpi { get; set; }

        /// <summary>
        /// The horizontal offset of the texture from the shape's origin in points. A positive value moves the texture to the right, while a negative value moves it to the left.
        /// </summary>
        public double? TileOffsetX { get; set; }

        /// <summary>
        /// The vertical offset of the texture from the shape's origin in points. A positive value moves the texture down, while a negative value moves it up.
        /// </summary>
        public double? TileOffsetY { get; set; }

        /// <summary>
        /// The horizontal scale for the texture fill as a percentage.
        /// </summary>
        public double? TileScaleX { get; set; }

        /// <summary>
        /// The vertical scale for the texture fill as a percentage.
        /// </summary>
        public double? TileScaleY { get; set; }

        /// <summary>
        /// Internal image link.
        /// </summary>
        public ResourceUri Image { get; set; }

        /// <summary>
        /// Base 64 image data.
        /// </summary>
        public string Base64Data { get; set; }

        /// <summary>
        /// SVG image data.
        /// </summary>
        public string SvgData { get; set; }

        /// <summary>
        /// true to delete picture cropped areas on save.
        /// </summary>
        public bool? DeletePictureCroppedAreas { get; set; }

        /// <summary>
        /// true to compress the picture image with the specified resolution (in dpi) on save.
        /// </summary>
        public double? Resolution { get; set; }

        /// <summary>
        /// Image transform effects.
        /// </summary>
        public List<ImageTransformEffect> ImageTransformList { get; set; }


        /// <summary>
        /// Property values to determine the type when deserializing from Json
        /// </summary>
        public static new Dictionary<string, object> TypeDeterminers
        {
            get
            {
                if (s_typeDeterminers == null)
                {
                    s_typeDeterminers = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
                    s_typeDeterminers.Add("Type", TypeEnum.Picture);
                }
                return s_typeDeterminers;
            }
        }

        private static Dictionary<string, object> s_typeDeterminers;
        /// <summary>
        /// Create an instance of the object
        /// </summary>
        public PictureFill() : base()
        {
            Type = TypeEnum.Picture;
        }

        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
            var sb = new StringBuilder();
            sb.Append("class PictureFill {\n");
            sb.Append("  Type: ").Append(this.Type).Append("\n");
            sb.Append("  CropBottom: ").Append(this.CropBottom).Append("\n");
            sb.Append("  CropLeft: ").Append(this.CropLeft).Append("\n");
            sb.Append("  CropRight: ").Append(this.CropRight).Append("\n");
            sb.Append("  CropTop: ").Append(this.CropTop).Append("\n");
            sb.Append("  Dpi: ").Append(this.Dpi).Append("\n");
            sb.Append("  TileOffsetX: ").Append(this.TileOffsetX).Append("\n");
            sb.Append("  TileOffsetY: ").Append(this.TileOffsetY).Append("\n");
            sb.Append("  TileScaleX: ").Append(this.TileScaleX).Append("\n");
            sb.Append("  TileScaleY: ").Append(this.TileScaleY).Append("\n");
            sb.Append("  TileAlignment: ").Append(this.TileAlignment).Append("\n");
            sb.Append("  TileFlip: ").Append(this.TileFlip).Append("\n");
            sb.Append("  Image: ").Append(this.Image).Append("\n");
            sb.Append("  Base64Data: ").Append(this.Base64Data).Append("\n");
            sb.Append("  SvgData: ").Append(this.SvgData).Append("\n");
            sb.Append("  DeletePictureCroppedAreas: ").Append(this.DeletePictureCroppedAreas).Append("\n");
            sb.Append("  Resolution: ").Append(this.Resolution).Append("\n");
            sb.Append("  PictureFillMode: ").Append(this.PictureFillMode).Append("\n");
            sb.Append("  ImageTransformList: ").Append(this.ImageTransformList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

}
