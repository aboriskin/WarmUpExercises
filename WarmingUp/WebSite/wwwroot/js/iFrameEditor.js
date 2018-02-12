'use strict';

(function () {
    var htmlEditor, cssEditor, jsEditor;

    $(function () {
        htmlEditor = initEditor("html", true);
        cssEditor = initEditor("css");
        jsEditor = initEditor("javascript");

        $("#tabs").tabs();
    });

    function initEditor(language, enableEmmet) {        
        var editor = ace.edit(`area-${language}`);
        var mode = 'ace/mode/' + language;
            editor.session.setMode(mode);

        if (enableEmmet) {                
            editor.setOption("enableEmmet", true);
        }            

        editor.getSession().on('change', _.debounce(updateContentIFrame, 1000));
        return editor;        
    }

    function updateContentIFrame() {
        var html = htmlEditor.getValue();
        var css = cssEditor.getValue();
        var js = jsEditor.getValue();

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
        $("#frame-result").contents().find("html")[0].innerHTML = result;                
        frames[0].window.eval(js);
    }

}());