using WebApp.services;

namespace WebApp
{
    public class UserComment
    {

        public string RawComment { get; set; }
        public string SanitizedComment { get; set; }

        public SanitizeService sanitizer = new SanitizeService();
        public UserComment(string rawComment) 
        {
            RawComment = rawComment;
            SanitizedComment = sanitizer.SanitizeText(rawComment);
        }

    }

    //XML GENERATE BY... COPY FROM THE URL API, THEN COPY, EDIT, SPECIAL PASTE, XML AS CLASES

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.purgomalum.com")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.purgomalum.com", IsNullable = false)]
    public partial class PurgoMalum
    {

        private string resultField;

        /// <remarks/>
        public string result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }







}
