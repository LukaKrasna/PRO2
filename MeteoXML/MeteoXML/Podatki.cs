using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoXML
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class data
    {

        private string languageField;

        private string creditField;

        private string credit_urlField;

        private string docs_urlField;

        private string disclaimer_urlField;

        private string copyright_urlField;

        private string privacy_policy_urlField;

        private string managing_editorField;

        private string web_masterField;

        private string suggested_pickupField;

        private byte suggested_pickup_periodField;

        private string two_day_history_urlField;

        private string domain_titleField;

        private byte domain_idField;

        private string domain_shortTitleField;

        private string domain_longTitleField;

        private byte domain_meteosiIdField;

        private string domain_meteosiTypeField;

        private decimal domain_latField;

        private decimal domain_lonField;

        private byte domain_altitudeField;

        private byte dataSource_titleField;

        private string tsValid_issuedField;

        private string tavg_var_descField;

        private string tavg_var_unitField;

        private string tx_var_descField;

        private string tx_var_unitField;

        private string tn_var_descField;

        private string tn_var_unitField;

        private string rhavg_var_descField;

        private string rhavg_var_unitField;

        private string rhx_var_descField;

        private string rhx_var_unitField;

        private string rhn_var_descField;

        private string rhn_var_unitField;

        private string td_var_descField;

        private string td_var_unitField;

        private string rr_var_descField;

        private string rr_var_unitField;

        private string lwavg_var_descField;

        private string lwavg_var_unitField;

        private dataMetData[] metDataField;

        private string idField;

        /// <remarks/>
        public string language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        public string credit
        {
            get
            {
                return this.creditField;
            }
            set
            {
                this.creditField = value;
            }
        }

        /// <remarks/>
        public string credit_url
        {
            get
            {
                return this.credit_urlField;
            }
            set
            {
                this.credit_urlField = value;
            }
        }

        /// <remarks/>
        public string docs_url
        {
            get
            {
                return this.docs_urlField;
            }
            set
            {
                this.docs_urlField = value;
            }
        }

        /// <remarks/>
        public string disclaimer_url
        {
            get
            {
                return this.disclaimer_urlField;
            }
            set
            {
                this.disclaimer_urlField = value;
            }
        }

        /// <remarks/>
        public string copyright_url
        {
            get
            {
                return this.copyright_urlField;
            }
            set
            {
                this.copyright_urlField = value;
            }
        }

        /// <remarks/>
        public string privacy_policy_url
        {
            get
            {
                return this.privacy_policy_urlField;
            }
            set
            {
                this.privacy_policy_urlField = value;
            }
        }

        /// <remarks/>
        public string managing_editor
        {
            get
            {
                return this.managing_editorField;
            }
            set
            {
                this.managing_editorField = value;
            }
        }

        /// <remarks/>
        public string web_master
        {
            get
            {
                return this.web_masterField;
            }
            set
            {
                this.web_masterField = value;
            }
        }

        /// <remarks/>
        public string suggested_pickup
        {
            get
            {
                return this.suggested_pickupField;
            }
            set
            {
                this.suggested_pickupField = value;
            }
        }

        /// <remarks/>
        public byte suggested_pickup_period
        {
            get
            {
                return this.suggested_pickup_periodField;
            }
            set
            {
                this.suggested_pickup_periodField = value;
            }
        }

        /// <remarks/>
        public string two_day_history_url
        {
            get
            {
                return this.two_day_history_urlField;
            }
            set
            {
                this.two_day_history_urlField = value;
            }
        }

        /// <remarks/>
        public string domain_title
        {
            get
            {
                return this.domain_titleField;
            }
            set
            {
                this.domain_titleField = value;
            }
        }

        /// <remarks/>
        public byte domain_id
        {
            get
            {
                return this.domain_idField;
            }
            set
            {
                this.domain_idField = value;
            }
        }

        /// <remarks/>
        public string domain_shortTitle
        {
            get
            {
                return this.domain_shortTitleField;
            }
            set
            {
                this.domain_shortTitleField = value;
            }
        }

        /// <remarks/>
        public string domain_longTitle
        {
            get
            {
                return this.domain_longTitleField;
            }
            set
            {
                this.domain_longTitleField = value;
            }
        }

        /// <remarks/>
        public byte domain_meteosiId
        {
            get
            {
                return this.domain_meteosiIdField;
            }
            set
            {
                this.domain_meteosiIdField = value;
            }
        }

        /// <remarks/>
        public string domain_meteosiType
        {
            get
            {
                return this.domain_meteosiTypeField;
            }
            set
            {
                this.domain_meteosiTypeField = value;
            }
        }

        /// <remarks/>
        public decimal domain_lat
        {
            get
            {
                return this.domain_latField;
            }
            set
            {
                this.domain_latField = value;
            }
        }

        /// <remarks/>
        public decimal domain_lon
        {
            get
            {
                return this.domain_lonField;
            }
            set
            {
                this.domain_lonField = value;
            }
        }

        /// <remarks/>
        public byte domain_altitude
        {
            get
            {
                return this.domain_altitudeField;
            }
            set
            {
                this.domain_altitudeField = value;
            }
        }

        /// <remarks/>
        public byte dataSource_title
        {
            get
            {
                return this.dataSource_titleField;
            }
            set
            {
                this.dataSource_titleField = value;
            }
        }

        /// <remarks/>
        public string tsValid_issued
        {
            get
            {
                return this.tsValid_issuedField;
            }
            set
            {
                this.tsValid_issuedField = value;
            }
        }

        /// <remarks/>
        public string tavg_var_desc
        {
            get
            {
                return this.tavg_var_descField;
            }
            set
            {
                this.tavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string tavg_var_unit
        {
            get
            {
                return this.tavg_var_unitField;
            }
            set
            {
                this.tavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public string tx_var_desc
        {
            get
            {
                return this.tx_var_descField;
            }
            set
            {
                this.tx_var_descField = value;
            }
        }

        /// <remarks/>
        public string tx_var_unit
        {
            get
            {
                return this.tx_var_unitField;
            }
            set
            {
                this.tx_var_unitField = value;
            }
        }

        /// <remarks/>
        public string tn_var_desc
        {
            get
            {
                return this.tn_var_descField;
            }
            set
            {
                this.tn_var_descField = value;
            }
        }

        /// <remarks/>
        public string tn_var_unit
        {
            get
            {
                return this.tn_var_unitField;
            }
            set
            {
                this.tn_var_unitField = value;
            }
        }

        /// <remarks/>
        public string rhavg_var_desc
        {
            get
            {
                return this.rhavg_var_descField;
            }
            set
            {
                this.rhavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string rhavg_var_unit
        {
            get
            {
                return this.rhavg_var_unitField;
            }
            set
            {
                this.rhavg_var_unitField = value;
            }
        }

        /// <remarks/>
        public string rhx_var_desc
        {
            get
            {
                return this.rhx_var_descField;
            }
            set
            {
                this.rhx_var_descField = value;
            }
        }

        /// <remarks/>
        public string rhx_var_unit
        {
            get
            {
                return this.rhx_var_unitField;
            }
            set
            {
                this.rhx_var_unitField = value;
            }
        }

        /// <remarks/>
        public string rhn_var_desc
        {
            get
            {
                return this.rhn_var_descField;
            }
            set
            {
                this.rhn_var_descField = value;
            }
        }

        /// <remarks/>
        public string rhn_var_unit
        {
            get
            {
                return this.rhn_var_unitField;
            }
            set
            {
                this.rhn_var_unitField = value;
            }
        }

        /// <remarks/>
        public string td_var_desc
        {
            get
            {
                return this.td_var_descField;
            }
            set
            {
                this.td_var_descField = value;
            }
        }

        /// <remarks/>
        public string td_var_unit
        {
            get
            {
                return this.td_var_unitField;
            }
            set
            {
                this.td_var_unitField = value;
            }
        }

        /// <remarks/>
        public string rr_var_desc
        {
            get
            {
                return this.rr_var_descField;
            }
            set
            {
                this.rr_var_descField = value;
            }
        }

        /// <remarks/>
        public string rr_var_unit
        {
            get
            {
                return this.rr_var_unitField;
            }
            set
            {
                this.rr_var_unitField = value;
            }
        }

        /// <remarks/>
        public string lwavg_var_desc
        {
            get
            {
                return this.lwavg_var_descField;
            }
            set
            {
                this.lwavg_var_descField = value;
            }
        }

        /// <remarks/>
        public string lwavg_var_unit
        {
            get
            {
                return this.lwavg_var_unitField;
            }
            set
            {
                this.lwavg_var_unitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("metData")]
        public dataMetData[] metData
        {
            get
            {
                return this.metDataField;
            }
            set
            {
                this.metDataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class dataMetData
    {

        private string validField;

        private string valid_UTCField;

        private string validStartField;

        private string validEndField;

        private decimal tavgField;

        private decimal txField;

        private decimal tnField;

        private decimal rhavgField;

        private decimal rhxField;

        private decimal rhnField;

        private decimal tdField;

        private decimal rrField;

        private decimal lwavgField;

        /// <remarks/>
        public string valid
        {
            get
            {
                return this.validField;
            }
            set
            {
                this.validField = value;
            }
        }

        /// <remarks/>
        public string valid_UTC
        {
            get
            {
                return this.valid_UTCField;
            }
            set
            {
                this.valid_UTCField = value;
            }
        }

        /// <remarks/>
        public string validStart
        {
            get
            {
                return this.validStartField;
            }
            set
            {
                this.validStartField = value;
            }
        }

        /// <remarks/>
        public string validEnd
        {
            get
            {
                return this.validEndField;
            }
            set
            {
                this.validEndField = value;
            }
        }

        /// <remarks/>
        public decimal tavg
        {
            get
            {
                return this.tavgField;
            }
            set
            {
                this.tavgField = value;
            }
        }

        /// <remarks/>
        public decimal tx
        {
            get
            {
                return this.txField;
            }
            set
            {
                this.txField = value;
            }
        }

        /// <remarks/>
        public decimal tn
        {
            get
            {
                return this.tnField;
            }
            set
            {
                this.tnField = value;
            }
        }

        /// <remarks/>
        public decimal rhavg
        {
            get
            {
                return this.rhavgField;
            }
            set
            {
                this.rhavgField = value;
            }
        }

        /// <remarks/>
        public decimal rhx
        {
            get
            {
                return this.rhxField;
            }
            set
            {
                this.rhxField = value;
            }
        }

        /// <remarks/>
        public decimal rhn
        {
            get
            {
                return this.rhnField;
            }
            set
            {
                this.rhnField = value;
            }
        }

        /// <remarks/>
        public decimal td
        {
            get
            {
                return this.tdField;
            }
            set
            {
                this.tdField = value;
            }
        }

        /// <remarks/>
        public decimal rr
        {
            get
            {
                return this.rrField;
            }
            set
            {
                this.rrField = value;
            }
        }

        /// <remarks/>
        public decimal lwavg
        {
            get
            {
                return this.lwavgField;
            }
            set
            {
                this.lwavgField = value;
            }
        }
    }


}
