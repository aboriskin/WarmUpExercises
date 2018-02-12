using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class ExerciseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public bool IncludeHtmlTab { get; set; }
        public bool IncludeCssTab { get; set; }
        public bool IncludeJavascriptTab { get; set; }

        public IFrameEditorModel AnswerModel { get; set; }
        public IFrameEditorModel StartModel { get; set; }        
    }
}
