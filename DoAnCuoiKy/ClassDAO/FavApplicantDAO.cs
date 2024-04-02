using DoAnCuoiKy.Company;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy
{
    internal class FavApplicantDAO
    {
        DBconnection db = new DBconnection();
        SqlConnection connStr = new SqlConnection(DoAnCuoiKy.Properties.Settings.Default.connStr);
        public void them(Candidate candidate)
        {
            string SQL = string.Format("INSERT INTO FavoriteApplicant ( ID,  Name,  gender,  nationality,  address,  DOB,  ExpYears,  email,  phone,  describe, ApplyPosition, Skill) VALUES ('{0}', '{1}' , '{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')",
                 candidate.ID, candidate.Name, candidate.Gender,
                 candidate.Nationality, candidate.Address, candidate.DOB, candidate.ExpYears,
                 candidate.Email, candidate.Phone, candidate.Describe, candidate.ApplyPosition, candidate.Skill);
            db.thucthi(SQL);
        }
        public void xoa(Candidate candidate)
        {
            string SQL = string.Format("DELETE FROM FavoriteApplicant WHERE  Name = '{0}' ", candidate.Name);
            db.thucthi(SQL);
        }
        public void LoadDanhSach(FFavoriteApplicants f)
        {
            List<Candidate> list = new List<Candidate>();
            try
            {
                string query = "SELECT * FROM FavoriteApplicant";
                SqlCommand command = new SqlCommand(query, connStr);
                connStr.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string ID = reader["ID"].ToString();
                    string Name = reader["Name"].ToString();
                    string gender = reader["Gender"].ToString();
                    string nationality = reader["Nationality"].ToString();
                    string address = reader["Address"].ToString();
                    string DOB = reader["DOB"].ToString();
                    string expYears = reader["ExpYears"].ToString();
                    string email = reader["Email"].ToString();
                    string phone = reader["Phone"].ToString();
                    string describe = reader["Describe"].ToString();
                    string applyPos = reader["ApplyPosition"].ToString();
                    string skill = reader["Skill"].ToString();
                    Candidate candidate = new Candidate(ID, Name, gender, nationality, address, DOB, expYears, email, phone, describe, applyPos, skill);
                    list.Add(candidate);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi truy vấn: " + ex.Message);
            }
            finally
            {
                connStr.Close();
            }
            foreach (Candidate candidate1 in list)
            {
                UCApplicants uCApplicants = new UCApplicants(candidate1);
                uCApplicants.btnFavorite.Hide();
                f.pnlFavApplicants.Controls.Add(uCApplicants);
            }
        }
        public void xoaUC(UCApplicants uCApplicants)
        {
            string SQL = string.Format("DELETE FROM FavoriteApplicant WHERE  ApplyPosition = '{0}' ",
              uCApplicants.lblCandidateApplyPos.Text);
            db.thucthi(SQL);
        }
    }
}
