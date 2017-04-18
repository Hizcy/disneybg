<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="userAchieve.aspx.cs" Inherits="user_userShow" %>

<asp:Content ID="Content1" ContentPlaceHolderID="header" Runat="Server">
   <script src="../js/echarts.min.js"></script>
    <script type="text/javascript" src="/js/datepicker/WdatePicker.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContent" Runat="Server">
        <section>
      <h2><strong style="color:grey;">常用操作</strong></h2> 
           <span class="item_name" style="width:120px;display:inline-block;">&nbsp;</span>

            <a class="link_btn" href="userShow.aspx?uid=<%=uid %>">查看代理详情</a>
            <a class="link_btn" href="userEdit.aspx?uid=<%=uid %>">修改基本信息</a>
           <a class="link_btn" href="userUperChange.aspx?uid=<%=uid %>" >更换上级代理</a> 
           <a class="link_btn" href="userAchieve.aspx?uid=<%=uid %>">查看代理业绩</a>
    
     </section>
    <section>
        <h2><strong>代理业绩汇总</strong></h2>
        <div>
            快速选择：
            <select class="select">
                <option>今天</option>
                <option>昨天</option>
                <option>近7天内</option>
                <option>近30天内</option>
                <option>自定义时间</option>
        </select>
            <br />
            开始时间：<input id="startDate" class="Wdate" type="text" onFocus="var endDate=$dp.$('endDate');WdatePicker({onpicked:function(){endDate.focus();},maxDate:'#F{$dp.$D(\'endDate\')}',dateFmt:'yyyy-MM-dd HH:mm:ss'})"/>
            截止时间：<input id="endDate" class="Wdate" type="text" onFocus="WdatePicker({minDate:'#F{$dp.$D(\'startDate\')}',dateFmt:'yyyy-MM-dd HH:mm:ss'})"/>
            <br />
            <input type="submit" class="link_btn" value="查询">
        </div>
         <div id="achievechart" style="width: 800px;height:450px;"></div>
        <script type="text/javascript">
            // 基于准备好的dom,初始化echarts实例
            var myChart = echarts.init(document.getElementById('achievechart'));

            // 指定图表的配置项和数据
            var option = {
                title: {
                    text: '销售业绩'
                },
                tooltip: {},
                legend: {
                    data: ['销量']
                },
                xAxis: {
                    data: ["0", "1", "2", "3", "4", "5", "6", "7", "8", "8", "10", "11", "12", "13", "14", "15","16", "17", "18", "19", "20", "21","22","23","24"]
                },
                yAxis: {},
                series: [{
                    name: '销量',
                    type: 'line',
                    data: ["30", "13", "42", "33", "24", "15", "86", "71", "338", "338", "1110", "211", "1222", "1113", "2214", "125","213","127","3123","3123","3321","331","3123","123","123"]
                }]
            };

            // 使用刚指定的配置项和数据显示图表。
            myChart.setOption(option);
    </script>
    </section>
</asp:Content>

