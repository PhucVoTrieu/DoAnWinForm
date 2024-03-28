using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class CandidateDAO
    {
        DBconnection db = new DBconnection();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        FFindingCandidate FFindingCandidate = new FFindingCandidate();
        public void them(Candidate candidate)
        {
            string SQL = string.Format("INSERT INTO Profile ( ID,  Name,  gender,  nationality,  address,  DOB,  ExpYears,  email,  phone,  describe) VALUES ('{0}', '{1}' , '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                candidate.ID, candidate.Name, candidate.Gender,
                candidate.Nationality, candidate.Address, candidate.DOB, candidate.ExpYears,
                candidate.Email,candidate.Phone,candidate.Describe);
            db.thucthi(SQL);
            

        }
        public DataTable loadDanhSach()
        {
            string sqlStr = string.Format("SELECT * FROM Profile");
            return db.load(sqlStr);
        }
    }
}
