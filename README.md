     <div>
       
       
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">using</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> System;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">using</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> System.Text;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">using</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> System.IO;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">using</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> System.Collections;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">using</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> System.Net;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">using</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> System.Net.Sockets;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">using</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> System.Threading;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><o:p>&nbsp;</o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">namespace</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> HTTPServer<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">class</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#2B91AF;mso-ansi-language:
EN">Interaction</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">const</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> Server_Directory = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;
mso-ansi-language:EN">&quot;C:</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:#FF007F;mso-ansi-language:EN">\\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">Work</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#FF007F;mso-ansi-language:EN">\\</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:EN">HTTPServer</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#FF007F;mso-ansi-language:
EN">\\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">page_content</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#FF007F;mso-ansi-language:
EN">\\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">const</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> Error_Message = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;None&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:black;mso-ansi-language:EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">const</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> Main_Page = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;nsu.htm&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:black;mso-ansi-language:EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><o:p>&nbsp;</o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>TcpClient Client;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Hashtable Contents = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">new</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"> Hashtable();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;
font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;
font-family:Consolas;color:green"> </span><span style="font-size:9.5pt;
font-family:Consolas;color:gray">&lt;</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:gray;mso-ansi-language:EN">summary</span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&gt;</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> По строке запроса вычисляем путь к файлу.</span><span style="font-size:9.5pt;font-family:Consolas;
color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:gray;mso-ansi-language:EN">///</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:green;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:EN">&lt;/summary&gt;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> GetPath(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"> request)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">int</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> space1 = request.IndexOf(</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:#A31515;mso-ansi-language:EN">&quot; &quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">int</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> space2 = request.IndexOf(</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:#A31515;mso-ansi-language:EN">&quot; &quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">, space1 + 1);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> url = request.Substring(space1 + 2, space2 - space1 - 2);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">if</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (url == </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">&quot;&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>url = Main_Page;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">return</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> Server_Directory + url;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:gray;mso-ansi-language:EN">///</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:green;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:gray;mso-ansi-language:EN">&lt;summary&gt;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;
font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;
font-family:Consolas;color:green"> По файлу вычисляем тип содержимого в нём</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:gray;mso-ansi-language:EN">///</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:green;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:EN">&lt;/summary&gt;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> GetContent(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"> file_path)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> ext = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">&quot;&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">int</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> dot = file_path.LastIndexOf(</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:#A31515;mso-ansi-language:EN">&quot;.&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">if</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (dot &gt;= 0)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>ext = file_path.Substring(dot, file_path.Length - dot).ToUpper();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">if</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (Contents[ext] == </span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:blue;mso-ansi-language:EN">null</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">return</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">&quot;application/&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> + ext;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">else</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">return</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">)Contents[ext];<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;
font-family:Consolas;color:black">}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> </span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&lt;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:
EN">summary</span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&gt;</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> Отправляем заголовок клиенту.</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> </span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&lt;/</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:
EN">summary</span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&gt;</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">void</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"> WriteHeaderToClient(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> content_type, </span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:blue;mso-ansi-language:EN">long</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> length)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> str = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">&quot;HTTP/1.1 200 OK</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#FF007F;mso-ansi-language:
EN">\n</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">Content-type: &quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> + content_type<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>+ </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#FF007F;mso-ansi-language:EN">\n</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:EN">Content-Encoding: 8bit</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#FF007F;mso-ansi-language:EN">\n</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:EN">Content-Length:&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> + length.ToString()<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>+ </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#FF007F;mso-ansi-language:EN">\n</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:#FF66B2;mso-ansi-language:EN">\n</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Client.GetStream().Write(Encoding.ASCII.GetBytes(str), 0, str.Length);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;
font-family:Consolas;color:black">}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> </span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&lt;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:
EN">summary</span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&gt;</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"><span style="mso-spacerun:yes">&nbsp; </span>Отвечаем на запрос клиенту</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> </span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&lt;/</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:
EN">summary</span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&gt;</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">void</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"> WriteToClient(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> request)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> file_path = GetPath(request);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">if</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (file_path.IndexOf(</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:#A31515;mso-ansi-language:EN">&quot;..&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">) &gt;= 0 || !File.Exists(file_path))<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>WriteHeaderToClient(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;text/plain&quot;</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN">, Error_Message.Length);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Client.GetStream().Write(Encoding.ASCII.GetBytes(Error_Message), 0, Error_Message.Length);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">return</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>FileStream file = File.Open(file_path, FileMode.Open);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>WriteHeaderToClient(GetContent(file_path), file.Length);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">byte</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">[] buf = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">new</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">byte</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">[1024];<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">int</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> len;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">while</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> ((len = file.Read(buf, 0, 1024)) != 0)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Client.GetStream().Write(buf, 0, len);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>file.Close();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">void</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> Interact()<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">try</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">byte</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">[] buffer = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">new</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">byte</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">[1024];<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> request = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:#A31515;mso-ansi-language:EN">&quot;&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">while</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">true</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">int</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> count = Client.GetStream().Read(buffer, 0, 1024);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>request += Encoding.ASCII.GetString(buffer, 0, count);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">if</span><span style="font-size:9.5pt;font-family:Consolas;color:black"> (</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">request</span><span style="font-size:9.5pt;font-family:Consolas;color:black">.</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN">IndexOf</span><span style="font-size:9.5pt;font-family:Consolas;color:black">(</span><span style="font-size:9.5pt;font-family:Consolas;color:#A31515">&quot;</span><span style="font-size:9.5pt;font-family:Consolas;color:#FF007F">\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#FF007F;mso-ansi-language:
EN">r</span><span style="font-size:9.5pt;font-family:Consolas;color:#FF66B2">\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#FF66B2;mso-ansi-language:
EN">n</span><span style="font-size:9.5pt;font-family:Consolas;color:#FF007F">\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#FF007F;mso-ansi-language:
EN">r</span><span style="font-size:9.5pt;font-family:Consolas;color:#FF66B2">\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#FF66B2;mso-ansi-language:
EN">n</span><span style="font-size:9.5pt;font-family:Consolas;color:#A31515">&quot;</span><span style="font-size:9.5pt;font-family:Consolas;color:black">) &gt;= 0) </span><span style="font-size:9.5pt;font-family:Consolas;color:green">// Запрос обрывается \</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:green;mso-ansi-language:
EN">r</span><span style="font-size:9.5pt;font-family:Consolas;color:green">\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:green;mso-ansi-language:
EN">n</span><span style="font-size:9.5pt;font-family:Consolas;color:green">\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:green;mso-ansi-language:
EN">r</span><span style="font-size:9.5pt;font-family:Consolas;color:green">\</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:green;mso-ansi-language:
EN">n</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:green"> </span><span style="font-size:9.5pt;font-family:Consolas;
color:green">последовательностью</span><span style="font-size:9.5pt;font-family:
Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>WriteToClient(request);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>request = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN">;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">catch</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (Exception)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">protected</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">void</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> SetContents()<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Contents.Add(</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:#A31515;mso-ansi-language:EN">&quot;&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">, </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;
mso-ansi-language:EN">&quot;application/unknown&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Contents.Add(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;.HTML&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:black;mso-ansi-language:EN">, </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;text/html&quot;</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Contents.Add(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;.HTM&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:black;mso-ansi-language:EN">, </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;text/html&quot;</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Contents.Add(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;.TXT&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:black;mso-ansi-language:EN">, </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;text/plain&quot;</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Contents.Add(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;.GIF&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:black;mso-ansi-language:EN">, </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;image/gif&quot;</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Contents.Add(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;.JPG&quot;</span><span lang="EN" style="font-size:9.5pt;font-family:
Consolas;color:black;mso-ansi-language:EN">, </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#A31515;mso-ansi-language:
EN">&quot;image/jpeg&quot;</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN">);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> Interaction(TcpClient client)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Client = client;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>SetContents();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Thread interact = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">new</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"> Thread(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">new</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> ThreadStart(Interact));<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>interact.Start();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><o:p>&nbsp;</o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">class</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:#2B91AF;mso-ansi-language:
EN">Server</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">private</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> TcpListener Listener;<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><o:p>&nbsp;</o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> Server(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">int</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:black;mso-ansi-language:EN"> port)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Listener = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">new</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> TcpListener(port);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Listener.Start();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Listen();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>~Server()<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">if</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (Listener != </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">null</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Listener</span><span style="font-size:9.5pt;font-family:Consolas;color:black">.</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">Stop</span><span style="font-size:9.5pt;font-family:Consolas;color:black">();<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> </span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&lt;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:
EN">summary</span><span style="font-size:9.5pt;font-family:Consolas;color:gray">&gt;</span><span style="font-size:9.5pt;font-family:Consolas;color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span style="font-size:9.5pt;font-family:Consolas;color:gray">///</span><span style="font-size:9.5pt;font-family:Consolas;color:green"> Ждём подключений к нашему серверу и обрабатываем их</span><span style="font-size:9.5pt;font-family:Consolas;
color:black"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span style="font-size:
9.5pt;font-family:Consolas;color:black"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:gray;mso-ansi-language:EN">///</span><span lang="EN" style="font-size:9.5pt;
font-family:Consolas;color:green;mso-ansi-language:EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:gray;mso-ansi-language:EN">&lt;/summary&gt;</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"><o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">public</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">void</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> Listen()<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">while</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> (</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">true</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">new</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> Interaction(Listener.AcceptTcpClient());<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>[STAThread]<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span></span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:blue;mso-ansi-language:EN">static</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:
EN"> </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:blue;mso-ansi-language:EN">void</span><span lang="EN" style="font-size:
9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"> Main(</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">string</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN">[] args)<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>{<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>Server server = </span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:blue;mso-ansi-language:
EN">new</span><span lang="EN" style="font-size:9.5pt;font-family:Consolas;
color:black;mso-ansi-language:EN"> Server(8123);<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN"><span style="mso-spacerun:yes">&nbsp;&nbsp;&nbsp; </span>}<o:p></o:p></span></p>
            <p class="MsoNormal" style="margin-bottom:0cm;margin-bottom:.0001pt;line-height:
normal;mso-layout-grid-align:none;text-autospace:none">
                <span lang="EN" style="font-size:9.5pt;font-family:Consolas;color:black;mso-ansi-language:EN">}</span><span lang="EN" style="mso-ascii-font-family:Calibri;mso-hansi-font-family:Calibri;
mso-bidi-font-family:Calibri;mso-ansi-language:EN"><o:p></o:p></span></p>
            <p class="MsoNormal">
                <o:p>&nbsp;</o:p></p>
        </div>
