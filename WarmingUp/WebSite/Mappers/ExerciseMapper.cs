using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Models;

namespace WebSite.Mappers
{
    public class ExerciseMapper : IMapper<ExerciseEntity, ExerciseModel>
    {
        private ExerciseMapper()
        {
        }

        public static ExerciseMapper Instance { get; private set; } = new ExerciseMapper();

        public void Map(ExerciseEntity from, ExerciseModel to)
        {
            to.Id = from.Id;
            to.Name = from.Name;
            to.Description = from.Description;
            to.Notes = from.Notes;

            to.IncludeHtmlTab = from.IncludeHtmlTab;
            to.IncludeCssTab = from.IncludeCssTab;
            to.IncludeJavascriptTab = from.IncludeJavascriptTab;

            to.AnswerModel = new IFrameEditorModel
            {
                Html = from.AnswerHtml,
                Css = from.AnswerCss,
                Javascript = from.AnswerJavascript
            };

            to.StartModel = new IFrameEditorModel
            {
                Html = from.StartHtml,
                Css = from.StartCss,
                Javascript = from.StartJavascript
            };
        }

        public void MapBack(ExerciseModel from, ExerciseEntity to)
        {
            to.Id = from.Id;
            to.Name = from.Name;
            to.Description = from.Description;
            to.Notes = from.Notes;

            to.IncludeHtmlTab = from.IncludeHtmlTab;
            to.IncludeCssTab = from.IncludeCssTab;
            to.IncludeJavascriptTab = from.IncludeJavascriptTab;

            to.AnswerHtml = from.AnswerModel.Html;
            to.AnswerCss = from.AnswerModel.Css;
            to.AnswerJavascript = from.AnswerModel.Javascript;

            to.StartHtml = from.StartModel.Html;
            to.StartCss = from.StartModel.Css;
            to.StartHtml = from.StartModel.Javascript;            
        }
    }
}
