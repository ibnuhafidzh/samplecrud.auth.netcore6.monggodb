namespace WebApp.Models
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Object
    {
        public string type { get; set; }
        public string version { get; set; }
        public string originX { get; set; }
        public string originY { get; set; }
        public double left { get; set; }
        public double top { get; set; }
        public int? width { get; set; }
        public double? height { get; set; }
        public string fill { get; set; }
        public string stroke { get; set; }
        public int strokeWidth { get; set; }
        public object strokeDashArray { get; set; }
        public string strokeLineCap { get; set; }
        public int strokeDashOffset { get; set; }
        public string strokeLineJoin { get; set; }
        public int strokeMiterLimit { get; set; }
        public int scaleX { get; set; }
        public int scaleY { get; set; }
        public int angle { get; set; }
        public bool flipX { get; set; }
        public bool flipY { get; set; }
        public int opacity { get; set; }
        public object shadow { get; set; }
        public bool visible { get; set; }
        public object clipTo { get; set; }
        public string backgroundColor { get; set; }
        public string fillRule { get; set; }
        public string paintFirst { get; set; }
        public string globalCompositeOperation { get; set; }
        public object transformMatrix { get; set; }
        public int skewX { get; set; }
        public int skewY { get; set; }
        public int rx { get; set; }
        public int ry { get; set; }
        public string text { get; set; }
        public int? fontSize { get; set; }
        public string fontWeight { get; set; }
        public string fontFamily { get; set; }
        public string fontStyle { get; set; }
        public double? lineHeight { get; set; }
        public bool? underline { get; set; }
        public bool? overline { get; set; }
        public bool? linethrough { get; set; }
        public string textAlign { get; set; }
        public string textBackgroundColor { get; set; }
        public int? charSpacing { get; set; }
        public Styles styles { get; set; }
    }

    public class JsonScada
    {
        public string version { get; set; }
        public List<Object> objects { get; set; }
    }



}
