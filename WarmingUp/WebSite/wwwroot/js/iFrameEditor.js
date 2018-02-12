'use strict';

(function () {
    var startHtmlEditor, startCssEditor, startJsEditor;
    var answerHtmlEditor, answerCssEditor, answerJsEditor;

    $(function () {
        startHtmlEditor = initEditor("start", "html", updateContentStartIFrame, true);
        startCssEditor = initEditor("start", "css", updateContentStartIFrame);
        startJsEditor = initEditor("start", "javascript", updateContentStartIFrame);

        answerHtmlEditor = initEditor("answer", "html", updateContentAnswerIFrame, true);
        answerCssEditor = initEditor("answer", "css", updateContentAnswerIFrame);
        answerJsEditor = initEditor("answer", "javascript", updateContentAnswerIFrame);

        $("#answer-tabs").tabs();
        $("#start-tabs").tabs();
    });

    function initEditor(prefix, language, updateIFrameCallback, enableEmmet) {        
        var editor = ace.edit(`area-${prefix}-${language}`);
        var mode = 'ace/mode/' + language;
            editor.session.setMode(mode);

        if (enableEmmet) {                
            editor.setOption("enableEmmet", true);
        }            

        editor.getSession().on('change', _.debounce(updateIFrameCallback, 1000));
        return editor;        
    }

    function updateContentStartIFrame() {
        var html = startHtmlEditor.getValue();
        var css = startCssEditor.getValue();
        var js = startJsEditor.getValue();

        var result = 
`<head>
<meta name="viewport" content="width=device-width" />
<title>IFrame content</title>
<style>${css}</style>
</head>
<body>
${html}
<script>${js}</scr` + `ipt>
</body>`;
        $("#frame-start-result").contents().find("html")[0].innerHTML = result;                
        frames[0].window.eval(js);
    }

    function updateContentAnswerIFrame() {
        var html = answerHtmlEditor.getValue();
        var css = answerCssEditor.getValue();
        var js = answerJsEditor.getValue();

        var result =
            `<head>
<meta name="viewport" content="width=device-width" />
<title>IFrame content</title>
<style>${css}</style>
</head>
<body>
${html}
<script>${js}</scr` + `ipt>
</body>`;
        $("#frame-answer-result").contents().find("html")[0].innerHTML = result;
        frames[0].window.eval(js);
    }

}());