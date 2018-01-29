﻿using Dos.DataAccess.Base;
using Dos.ORM;
using FancyFix.OA.Model;
using System.Collections.Generic;

namespace FancyFix.OA.Bll
{
    public class BllQuestionnaire_Info : ServiceBase<Questionnaire_Info>
    {
        public static BllQuestionnaire_Info Instance()
        {
            return new BllQuestionnaire_Info();
        }

        public static List<Questionnaire_Info> PageList(int page, int pageSize, out long records)
        {
            var where = new Where<Questionnaire_Info>();

            var p = Db.Context.From<Questionnaire_Info>()
                 .Select((a) => new { a.Id, a.Title, a.SubjectId, a.Options, a.Type, a.Answer, a.Remark, a.Score, a.Sequence })
                 .Where(where);

            records = p.Count();
            return p.Page(pageSize, page).OrderBy(o => o.Sequence).ToList();
        }

    }
}
