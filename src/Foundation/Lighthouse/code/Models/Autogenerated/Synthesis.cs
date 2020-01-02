//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Foundation.Lighthouse.Model.Autogenerated.Foundation.Lighthouse
{


    /// <summary>Represents the /sitecore/templates/Foundation/Lighthouse/_Lighthouse template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{BB102C6B-C167-4453-9A76-BC44F8889424}", "al17mUw6XaQQCwBRCtuWfxLa6Es=", "Default Configuration")]
    public partial interface I_LighthouseItem : Synthesis.IStandardTemplateItem
    {

        /// <summary>Represents the Data field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("data")]
        Synthesis.FieldTypes.Interfaces.ITextField Data
        {
            get;
        }

        /// <summary>Represents the Perfomance field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("perfomance")]
        Synthesis.FieldTypes.Interfaces.ITextField Perfomance
        {
            get;
        }

        /// <summary>Represents the Accessibility field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("accessibility")]
        Synthesis.FieldTypes.Interfaces.ITextField Accessibility
        {
            get;
        }

        /// <summary>Represents the BestPractices field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("bestpractices")]
        Synthesis.FieldTypes.Interfaces.ITextField BestPractices
        {
            get;
        }

        /// <summary>Represents the SEO field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("seo")]
        Synthesis.FieldTypes.Interfaces.ITextField SEO
        {
            get;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Foundation.Lighthouse.Model.Autogenerated.Concrete.Foundation.Lighthouse
{


    /// <summary>Represents the /sitecore/templates/Foundation/Lighthouse/_Lighthouse template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public partial class _Lighthouse : global::Synthesis.StandardTemplateItem, global::Foundation.Lighthouse.Model.Autogenerated.Foundation.Lighthouse.I_LighthouseItem
    {

        private Synthesis.FieldTypes.TextField _data;

        private Synthesis.FieldTypes.TextField _perfomance;

        private Synthesis.FieldTypes.TextField _accessibility;

        private Synthesis.FieldTypes.TextField _bestPractices;

        private Synthesis.FieldTypes.TextField _sEO;

        public _Lighthouse(Sitecore.Data.Items.Item innerItem) :
                base(innerItem)
        {
        }

        public _Lighthouse(global::System.Collections.Generic.IDictionary<string, string> searchFields) :
                base(searchFields)
        {
        }

        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName
        {
            get
            {
                return "_Lighthouse";
            }
        }

        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId
        {
            get
            {
                return new Sitecore.Data.ID("{BB102C6B-C167-4453-9A76-BC44F8889424}");
            }
        }

        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId
        {
            get
            {
                return ItemTemplateId;
            }
        }

        /// <summary>Represents the Data field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("data")]
        public Synthesis.FieldTypes.Interfaces.ITextField Data
        {
            get
            {
                if (_data == null)
                {
                    _data = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{2B81B040-5376-4C5C-81F2-EBB106D4BD29}"], "/sitecore/templates/Foundation/Lighthouse/_Lighthouse", "Data"), this.GetSearchFieldValue("data"));
                }
                return _data;
            }
        }

        /// <summary>Represents the Perfomance field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("perfomance")]
        public Synthesis.FieldTypes.Interfaces.ITextField Perfomance
        {
            get
            {
                if (_perfomance == null)
                {
                    _perfomance = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{3D927627-E1B5-4D61-B946-C83BE74C78A3}"], "/sitecore/templates/Foundation/Lighthouse/_Lighthouse", "Perfomance"), this.GetSearchFieldValue("perfomance"));
                }
                return _perfomance;
            }
        }

        /// <summary>Represents the Accessibility field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("accessibility")]
        public Synthesis.FieldTypes.Interfaces.ITextField Accessibility
        {
            get
            {
                if (_accessibility == null)
                {
                    _accessibility = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{69C93298-AB4A-4F64-99BA-C08A3397B7B5}"], "/sitecore/templates/Foundation/Lighthouse/_Lighthouse", "Accessibility"), this.GetSearchFieldValue("accessibility"));
                }
                return _accessibility;
            }
        }

        /// <summary>Represents the BestPractices field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("bestpractices")]
        public Synthesis.FieldTypes.Interfaces.ITextField BestPractices
        {
            get
            {
                if (_bestPractices == null)
                {
                    _bestPractices = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{A81C12DC-3C3F-471E-8F9F-1A481FCDAA17}"], "/sitecore/templates/Foundation/Lighthouse/_Lighthouse", "BestPractices"), this.GetSearchFieldValue("bestpractices"));
                }
                return _bestPractices;
            }
        }

        /// <summary>Represents the SEO field</summary>
        [Sitecore.ContentSearch.IndexFieldAttribute("seo")]
        public Synthesis.FieldTypes.Interfaces.ITextField SEO
        {
            get
            {
                if (_sEO == null)
                {
                    _sEO = new Synthesis.FieldTypes.TextField(new global::Synthesis.FieldTypes.LazyField(() => InnerItem.Fields["{2CBB7894-D510-4CE3-A1ED-FD9DC93A76E1}"], "/sitecore/templates/Foundation/Lighthouse/_Lighthouse", "SEO"), this.GetSearchFieldValue("seo"));
                }
                return _sEO;
            }
        }
    }

    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public class _LighthouseInitializer : Synthesis.Initializers.ITemplateInitializer
    {

        public Sitecore.Data.ID InitializesTemplateId
        {
            get
            {
                return new Sitecore.Data.ID("{BB102C6B-C167-4453-9A76-BC44F8889424}");
            }
        }

        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem)
        {
            return new _Lighthouse(innerItem);
        }

        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields)
        {
            return new _Lighthouse(searchFields);
        }
    }
}