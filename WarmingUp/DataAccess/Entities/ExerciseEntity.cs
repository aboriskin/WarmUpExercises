using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class ExerciseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public string StartHtml { get; set; }
        public string AnswerHtml { get; set; }
        public bool IncludeHtmlTab { get; set; }

        public string StartCss { get; set; }
        public string AnswerCss { get; set; }
        public bool IncludeCssTab { get; set; }

        public string StartJavascript { get; set; }
        public string AnswerJavascript { get; set; }
        public bool IncludeJavascriptTab { get; set; }

    }
}
