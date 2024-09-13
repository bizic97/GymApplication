using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gym_Application
{
    public class DataAccsess
    {
        

        public void InsertMember(string memberName, string phoneNumber, int age, string gender, int amount, string timing)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Gym_Database")))
            {
                List<Member> members = new List<Member>();
                members.Add(new Member{ MemberName = memberName, PhoneNumber = phoneNumber, Gender = gender, Age = age, Amount = amount, Timing = timing });
                connection.Execute("dbo.Member_Insert @MemberName, @PhoneNumber, @Gender, @Age, @Amount, @Timing", members);
            }
        }

        /*public List<Member> Populate(string memberName)
        {
            
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("Gym_Database")))
            {
                return connection.Query<Member>("dbo.Get_By_Member_Name", new { MemberName = memberName }).ToList();

            }

            

        }*/
       
    }
}
