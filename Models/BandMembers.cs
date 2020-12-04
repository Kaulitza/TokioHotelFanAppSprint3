using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokioHotelFanApp.Models
{
    public class BandMembers
    {
        int _band_id;
        string _band_member_name;
        int _age_id;
        int _instruments;
        DateTime _dob;
        string _cob;
        string _curr_country;
        string _relation_status;

        public int BandID
        {
            get { return _band_id; }
            set { _band_id = value; }
        }

        public string Bband_member_name
        {
            get { return _band_member_name; }
            set { _band_member_name = value; }
        }
        public int Age_id
        {
            get { return _age_id; }
            set { _age_id = value; }
        }
        public int Instruments
        {
            get { return _instruments; }
            set { _instruments = value; }
        }
        public DateTime DateofBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }
        public string CountryofBirth
        {
            get { return _cob; }
            set { _cob = value; }
        }
        public string CurrentCountry
        {
            get { return _curr_country; }
            set { _curr_country = value; }
        }
        public string Relation_status
        {
            get { return _relation_status; }
            set { _relation_status = value; }
        }
    }
}
