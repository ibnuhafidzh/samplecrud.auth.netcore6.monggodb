namespace WebApp.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RootFabricJs
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("objects")]
        public RootFabricJsObject[] Objects { get; set; }
    }

    public partial class RootFabricJsObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("originX")]
        public string OriginX { get; set; }

        [JsonProperty("originY")]
        public string OriginY { get; set; }

        [JsonProperty("left")]
        public double Left { get; set; }

        [JsonProperty("top")]
        public double Top { get; set; }

        [JsonProperty("width")]
        public double Width { get; set; }

        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("fill")]
        public string Fill { get; set; }

        [JsonProperty("stroke")]
        public object Stroke { get; set; }

        [JsonProperty("strokeWidth")]
        public long StrokeWidth { get; set; }

        [JsonProperty("strokeDashArray")]
        public object StrokeDashArray { get; set; }

        [JsonProperty("strokeLineCap")]
        public string StrokeLineCap { get; set; }

        [JsonProperty("strokeDashOffset")]
        public long StrokeDashOffset { get; set; }

        [JsonProperty("strokeLineJoin")]
        public string StrokeLineJoin { get; set; }

        [JsonProperty("strokeMiterLimit")]
        public long StrokeMiterLimit { get; set; }

        [JsonProperty("scaleX")]
        public double ScaleX { get; set; }

        [JsonProperty("scaleY")]
        public double ScaleY { get; set; }

        [JsonProperty("angle")]
        public long Angle { get; set; }

        [JsonProperty("flipX")]
        public bool FlipX { get; set; }

        [JsonProperty("flipY")]
        public bool FlipY { get; set; }

        [JsonProperty("opacity")]
        public long Opacity { get; set; }

        [JsonProperty("shadow")]
        public object Shadow { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("clipTo")]
        public object ClipTo { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("fillRule")]
        public string FillRule { get; set; }

        [JsonProperty("paintFirst")]
        public string PaintFirst { get; set; }

        [JsonProperty("globalCompositeOperation")]
        public string GlobalCompositeOperation { get; set; }

        [JsonProperty("transformMatrix")]
        public object TransformMatrix { get; set; }

        [JsonProperty("skewX")]
        public long SkewX { get; set; }

        [JsonProperty("skewY")]
        public long SkewY { get; set; }

        [JsonProperty("crossOrigin", NullValueHandling = NullValueHandling.Ignore)]
        public string CrossOrigin { get; set; }

        [JsonProperty("cropX", NullValueHandling = NullValueHandling.Ignore)]
        public long? CropX { get; set; }

        [JsonProperty("cropY", NullValueHandling = NullValueHandling.Ignore)]
        public long? CropY { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("src", NullValueHandling = NullValueHandling.Ignore)]
        public string Src { get; set; }

        [JsonProperty("filters", NullValueHandling = NullValueHandling.Ignore)]
        public object[] Filters { get; set; }

        [JsonProperty("objects", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectObject[] Objects { get; set; }

        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("fontSize", NullValueHandling = NullValueHandling.Ignore)]
        public long? FontSize { get; set; }

        [JsonProperty("fontWeight", NullValueHandling = NullValueHandling.Ignore)]
        public string FontWeight { get; set; }

        [JsonProperty("fontFamily", NullValueHandling = NullValueHandling.Ignore)]
        public string FontFamily { get; set; }

        [JsonProperty("fontStyle", NullValueHandling = NullValueHandling.Ignore)]
        public string FontStyle { get; set; }

        [JsonProperty("lineHeight", NullValueHandling = NullValueHandling.Ignore)]
        public double? LineHeight { get; set; }

        [JsonProperty("underline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Underline { get; set; }

        [JsonProperty("overline", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overline { get; set; }

        [JsonProperty("linethrough", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linethrough { get; set; }

        [JsonProperty("textAlign", NullValueHandling = NullValueHandling.Ignore)]
        public string TextAlign { get; set; }

        [JsonProperty("textBackgroundColor", NullValueHandling = NullValueHandling.Ignore)]
        public string TextBackgroundColor { get; set; }

        [JsonProperty("charSpacing", NullValueHandling = NullValueHandling.Ignore)]
        public long? CharSpacing { get; set; }

        [JsonProperty("styles", NullValueHandling = NullValueHandling.Ignore)]
        public Styles Styles { get; set; }
    }

    public partial class ObjectObject
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("originX")]
        public string OriginX { get; set; }

        [JsonProperty("originY")]
        public string OriginY { get; set; }

        [JsonProperty("left")]
        public long Left { get; set; }

        [JsonProperty("top")]
        public long Top { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("fill")]
        public string Fill { get; set; }

        [JsonProperty("stroke")]
        public string Stroke { get; set; }

        [JsonProperty("strokeWidth")]
        public long StrokeWidth { get; set; }

        [JsonProperty("strokeDashArray")]
        public object StrokeDashArray { get; set; }

        [JsonProperty("strokeLineCap")]
        public string StrokeLineCap { get; set; }

        [JsonProperty("strokeDashOffset")]
        public long StrokeDashOffset { get; set; }

        [JsonProperty("strokeLineJoin")]
        public string StrokeLineJoin { get; set; }

        [JsonProperty("strokeMiterLimit")]
        public long StrokeMiterLimit { get; set; }

        [JsonProperty("scaleX")]
        public long ScaleX { get; set; }

        [JsonProperty("scaleY")]
        public long ScaleY { get; set; }

        [JsonProperty("angle")]
        public long Angle { get; set; }

        [JsonProperty("flipX")]
        public bool FlipX { get; set; }

        [JsonProperty("flipY")]
        public bool FlipY { get; set; }

        [JsonProperty("opacity")]
        public long Opacity { get; set; }

        [JsonProperty("shadow")]
        public object Shadow { get; set; }

        [JsonProperty("visible")]
        public bool Visible { get; set; }

        [JsonProperty("clipTo")]
        public object ClipTo { get; set; }

        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonProperty("fillRule")]
        public string FillRule { get; set; }

        [JsonProperty("paintFirst")]
        public string PaintFirst { get; set; }

        [JsonProperty("globalCompositeOperation")]
        public string GlobalCompositeOperation { get; set; }

        [JsonProperty("transformMatrix")]
        public object TransformMatrix { get; set; }

        [JsonProperty("skewX")]
        public long SkewX { get; set; }

        [JsonProperty("skewY")]
        public long SkewY { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("path")]
        public Path[][] Path { get; set; }
    }

    public partial class Styles
    {
    }

    public partial struct Path
    {
        public long? Integer;
        public string String;

        public static implicit operator Path(long Integer) => new Path { Integer = Integer };
        public static implicit operator Path(string String) => new Path { String = String };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                PathConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PathConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Path) || t == typeof(Path?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.Integer:
                    var integerValue = serializer.Deserialize<long>(reader);
                    return new Path { Integer = integerValue };
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new Path { String = stringValue };
            }
            throw new Exception("Cannot unmarshal type Path");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Path)untypedValue;
            if (value.Integer != null)
            {
                serializer.Serialize(writer, value.Integer.Value);
                return;
            }
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            throw new Exception("Cannot marshal type Path");
        }

        public static readonly PathConverter Singleton = new PathConverter();
    }
}
