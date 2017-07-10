using IELTS_Helper.Database;
using IELTS_Helper.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IELTS_Helper.Service
{
    public class NoteService
    {
        public List<NoteModel> GetNotesByGroupName(string groupName)
        {
            List<NoteModel> noteLists = new List<NoteModel>();
            try
            {
                SQLiteSQLQueryHelper sqLiteSQLQueryHelper = new SQLiteSQLQueryHelper();
                SQLiteDataReader reader = sqLiteSQLQueryHelper.Select("note", "*", "WHERE note_group='" + groupName + "'");

                NoteModel noteModel;
                while (reader.Read())
                {
                    noteModel = new NoteModel();
                    noteModel.DisplayName = reader["name"].ToString();
                    noteModel.UUUID = reader["uuid"].ToString();
                    noteModel.Id = int.Parse(reader["id"].ToString());
                    noteModel.NoteGroup = reader["note_group"].ToString();
                    noteModel.Identifier = reader["identifier"].ToString();
                    noteLists.Add(noteModel);
                }
            }
            catch (SQLiteException sql)
            {
                return noteLists;
            }
            return noteLists;
        }
    }
}
