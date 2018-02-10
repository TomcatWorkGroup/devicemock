using BoilerDataTransmissionTest.Entities;
using BoilerDataTransmissionTest.Tool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoilerDataTransmissionTest
{
    public partial class DataGeneration : Form
    {
        public DataGeneration()
        {
            InitializeComponent();
            OnGenerateColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NJZJDeviceRunEntity model = null;
            IList<NJZJDeviceRunEntity> list = new List<NJZJDeviceRunEntity>();
            for (int i = 0; i < 20; i++)
            {
                TimeSpan ts = DateTime.Now.Subtract(Global.StartTime);
                model = new NJZJDeviceRunEntity
                {
                    #region
                    deviceno = i.ToString().PadLeft(4, '0'),
                    //nickname = "NM-" + i.ToString().PadLeft(2, '0'),
                    rundays = ts.Days,
                    runhours = ts.Hours,
                    paiyanwendugao = 1,
                    lushuiwendugao = 1,
                    chukouwendugao = 1,
                    chaoya = 1,
                    jixiandishuiwei = 1,
                    dishuiwei = 1,
                    gaoshuiwei = 1,
                    shuiweixinhaoluojicuo = 1,
                    lubiwendugao = 1,
                    fuyazhengqiwendugao = 1,
                    ranshaoqiguzhang = 1,
                    ranqixielou = 1,
                    ranqiyalidi = 1,
                    ranqiyaliyichang = 1,
                    ranqiyaligao = 1,
                    jishuibianpinqiguzhang = 1,
                    xunhuanbianpinqiguzhang = 1,
                    yinfengbianpinqiguzhang = 1,
                    gufengbianpinqiguzhang = 1,
                    ecigufengbianpinqiguzhang = 1,
                    lupaibianpinqiguzhang = 1,
                    jishuibengguzhang = 1,
                    xunhuanbengguzhang = 1,
                    xunhuanxitongqianya = 1,
                    didianya = 1,
                    gaodianya = 1,
                    quexiang = 1,
                    loudian = 1,
                    biansongqiguoyabaohu = 1,
                    guanjiancanshuyichang = 1,
                    shedingcanshuyichang = 1,
                    shizhongguzhang = 1,
                    cunchuqiguzhang = 1,
                    waibuliansuo = 1,
                    queyou = 1,
                    diyouwei = 1,
                    bentipaiyanwendugao = 1,
                    bentipaiyanwenduerror = 1,
                    paiyanwenduerror = 1,
                    lushuiwenduerror = 1,
                    chukouwenduerror = 1,
                    rukouwenduerror = 1,
                    jienengqichukouwenduerror = 1,
                    jienengqirukouwenduerror = 1,
                    jishuiwenduerror = 1,
                    lutangwenduerror = 1,
                    lutangchukouwenduerror = 1,
                    lubiwenduerror = 1,
                    ranliaowenduerror = 1,
                    kongyuqichukourefengwenduerror = 1,
                    fuyazhengqiwenduerror = 1,
                    guorezhengqiwenduerror = 1,
                    huilu1wenduerror = 1,
                    huilu2wenduerror = 1,
                    huilu3wenduerror = 1,
                    huilu4wenduerror = 1,
                    huilu5wenduerror = 1,
                    shiwaiwenduerror = 1,
                    zhengqiyalierror = 1,
                    jishuiyalierror = 1,
                    chukouyalierror = 1,
                    rukouyalierror = 1,
                    lutangyalierror = 1,
                    lutangchukouyalierror = 1,
                    ranqiyalierror = 1,
                    yicifengyaerror = 1,
                    ecifengyaerror = 1,
                    shunshiranliaoliangerror = 1,
                    shunshizhengqiliuliangerror = 1,
                    shunshijishuiliuliangerror = 1,
                    shunshixunhuanliuliangerror = 1,
                    shunshibushuiliuliangerror = 1,
                    guoluyeweierror = 1,
                    shuixiangyeweierror = 1,
                    paiyanyanghanliangerror = 1,
                    lupaisudufankuierror = 1,
                    yinfengshuchufankuierror = 1,
                    gufengshuchufankuierror = 1,
                    jishuishuchufankuierror = 1,
                    jixiandishuiweibaojingdianji = 1,
                    dishuiweibaojingdianji = 1,
                    dishuiweidianji = 1,
                    zhongshuiweidianji = 1,
                    gaoshuiweidianji = 1,
                    gaoshuiweibaojingdianji = 1,
                    shuixiangdiweidianji = 1,
                    shuixianggaoweidianji = 1,
                    jixiandiyeweibaojingxinhao = 1,
                    dibaojingxinhao = 1,
                    kongbengxinhao = 1,
                    gaobaojingxinhao = 1,
                    chaoyabaojingxinhao = 1,
                    fuhediaojieyalixinhao = 1,
                    qitingkongzhiyalixinhao = 1,
                    yalibiaodizhen = 1,
                    yalibiaogaozhen = 1,
                    lubichaowenxinhao = 1,
                    ranshaoqiguzhangbaojingxinhao = 1,
                    ranqixieloubaojingxinhao = 1,
                    ranqiyalidibaojingxinhao = 1,
                    ranqiyaliyichangbaojingxinhao = 1,
                    ranqiyaligaobaojingxinhao = 1,
                    xunhuanbengdongzuofankuixinhao = 1,
                    xunhuanbengdongzuofankuixinhaobei = 1,
                    jishuibengdongzuofankuixinhao = 1,
                    jishuibengdongzuofankuixinhaobei = 1,
                    yinfengjidongzuofankuixinhao = 1,
                    gufengjidongzuofankuixinhao = 1,
                    ecigufengjidongzuofankuixinhao = 1,
                    chuzhajidongzuofankuixinhao = 1,
                    jishuibianpinqiguzhangxinhao = 1,
                    yinfengbianpinqiguzhangxinhao = 1,
                    gufengbianpinqiguzhangxinhao = 1,
                    lupaibianpinqiguzhangxinhao = 1,
                    yandaodiefafankuixinhao = 1,
                    didianyabaojingxinhao = 1,
                    gaodianyabaojingxinhao = 1,
                    quexiangbaojingxinhao = 1,
                    loudianbaojingxinhao = 1,
                    queshuidianji2 = 1,
                    waibuliansuoxinhao = 1,
                    chaodiyabaohuxinhao = 1,
                    ranshaoqiqiting = 1,
                    ranshaoqidahuo = 1,
                    ranshaoqisanduanhuo = 1,
                    ranshaoqihuolizengjia = 1,
                    ranshaoqihuolijianshao = 1,
                    jishuibeng = 1,
                    jishuibengbei = 1,
                    jishuiliangzengjia = 1,
                    jishuiliangjianshao = 1,
                    xunhuanbeng = 1,
                    xunhuanbengbei = 1,
                    baojingshuchu = 1,
                    jiarezu1 = 1,
                    jiarezu2 = 1,
                    jiarezu3 = 1,
                    jiarezu4 = 1,
                    jiarezu5 = 1,
                    jiarezu6 = 1,
                    jiarezu7 = 1,
                    jiarezu8 = 1,
                    jiarezu9 = 1,
                    jiarezu10 = 1,
                    jiarezu11 = 1,
                    jiarezu12 = 1,
                    jiarezu13 = 1,
                    jiarezu14 = 1,
                    jiarezu15 = 1,
                    jiarezu16 = 1,
                    jiarezu17 = 1,
                    jiarezu18 = 1,
                    jiarezu19 = 1,
                    jiarezu20 = 1,
                    jiarezu21 = 1,
                    jiarezu22 = 1,
                    jiarezu23 = 1,
                    jiarezu24 = 1,
                    jiarezu25 = 1,
                    jiarezu26 = 1,
                    jiarezu27 = 1,
                    jiarezu28 = 1,
                    jiarezu29 = 1,
                    jiarezu30 = 1,
                    yinfengji = 1,
                    yinfengliangzengjia = 1,
                    yinfengliangjianshao = 1,
                    gufengji = 1,
                    gufengliangzengjia = 1,
                    gufengliangjianshao = 1,
                    ecigufengji = 1,
                    ecigufengliangzengjia = 1,
                    ecigufengliangjianshao = 1,
                    lupaihuojinliaojizhengzhuan = 1,
                    lupaifanzhuan = 1,
                    chuzhaji = 1,
                    dianhuoqi = 1,
                    jiayaobeng = 1,
                    paiwufa = 1,
                    bentipaiyanwendu = 1,
                    paiyanwendu = 1,
                    lushuiwendu = 1,
                    chukouwendu = 1,
                    rukouwendu = 1,
                    jienengqichukouwendu = 1,
                    jienengqirukouwendu = 1,
                    jishuiwendu = 1,
                    lutangwendu = 1,
                    lutangchukouwendu = 1,
                    lubiwendu = 1,
                    ranliaowendu = 1,
                    kongyuqichukourefengwendu = 1,
                    fuyazhengqiwendu = 1,
                    guorezhengqiwendu = 1,
                    huilu1wendu = 1,
                    huilu2wendu = 1,
                    huilu3wendu = 1,
                    huilu4wendu = 1,
                    huilu5wendu = 1,
                    shiwaiwendu = 1,
                    zhengqiyali = 1,
                    jishuiyali = 1,
                    chukouyali = 1,
                    rukouyali = 1,
                    lutangyali = 1,
                    lutangchukouyali = 1,
                    ranqiyali = 1,
                    yicifengya = 1,
                    ecifengya = 1,
                    shunshiranliaoliang = 1,
                    shunshizhengqiliuliang = 1,
                    shunshijishuiliuliang = 1,
                    shunshixunhuanliuliang = 1,
                    shunshibushuiliuliang = 1,
                    guoluyewei = 1,
                    shuixiangyewei = 1,
                    paiyanyanghanliang = 1,
                    lupaisudufankui = 1,
                    yinfengshuchufankui = 1,
                    gufengshuchufankui = 1,
                    jishuishuchufankui = 1,
                    ranshaoshuchuliangSetting = 1,
                    xunhuanshuchuliangSetting = 1,
                    jishuishuchuliangSetting = 1,
                    yinfengshuchuliangSetting = 1,
                    gufengshuchuliangSetting = 1,
                    ecigufengshuchuliangSetting = 1,
                    lupaihuojinliaoshuchuliangSetting = 1,
                    paiyanwenduSetting = 1,
                    baojingwenduSetting = 1,
                    tingluwenduSetting = 1,
                    mubiaowenduSetting = 1,
                    qiluwenduSetting = 1,
                    zhuanhuohuichaSetting = 1,
                    qiluhuichaSetting = 1,
                    kaibengwenduSetting = 1,
                    guanbengwenduSetting = 1,
                    baojingyaliSetting = 1,
                    tingluyaliSetting = 1,
                    mubiaoyaliSetting = 1,
                    qiluyaliSetting = 1,
                    zhuanhuohuichayaliSetting = 1,
                    qiluhuichayaliSetting = 1,
                    qianyanshiSetting = 1,
                    houyanshiSetting = 1,
                    qianchuisaoSetting = 1,
                    houchuisaoSetting = 1,
                    lubibaojingwenduSetting = 1,
                    lutangchukoubaojingwenduSetting = 1,
                    baohuwenduSetting = 1,
                    bentipaiyanwendubaojingzhiSetting = 1,
                    qidongshijian1Setting = 1,
                    tingzhishijian1Setting = 1,
                    qidongshijian2Setting = 1,
                    tingzhishijian2Setting = 1,
                    qidongshijian3Setting = 1,
                    tingzhishijian3Setting = 1,
                    qidongshijian4Setting = 1,
                    tingzhishijian4Setting = 1,
                    qidongshijian5Setting = 1,
                    tingzhishijian5Setting = 1,
                    qidongshijian6Setting = 1,
                    tingzhishijian6Setting = 1
                    #endregion
                   
                }; 
                list.Add(model);
            }
            dataGridView11.DataSource = new BindingList<NJZJDeviceRunEntity>(list);           
        }

        private void DataGeneration_Load(object sender, EventArgs e)
        {

        }

        private void OnGenerateColumns()
        {
            #region
           // dataGridView11.AutoGenerateColumns = false;
            dataGridView11.Columns.AddRange(
                new DataGridViewColumn[] {
            new DataGridViewTextBoxColumn { HeaderText = "设备编号", Name = "deviceNo",DataPropertyName=  "deviceNo"}
           ,new DataGridViewTextBoxColumn { HeaderText = "设备名称", Name = "nickName" ,DataPropertyName= "nickName" }
           ,new DataGridViewTextBoxColumn { HeaderText = "运行天数", Name = "runDays" ,DataPropertyName= "runDays"}
           ,new DataGridViewTextBoxColumn { HeaderText = "运行小时数", Name = "runHours" }
           ,new DataGridViewTextBoxColumn { HeaderText = "排烟温度高报警", Name = "paiyanwendugao" ,DataPropertyName=  "runHours"}
           ,new DataGridViewTextBoxColumn { HeaderText = "炉水温度高报警", Name = "lushuiwendugao" ,DataPropertyName= "lushuiwendugao"}
           ,new DataGridViewTextBoxColumn { HeaderText = "出口温度高报警", Name = "chukouwendugao" ,DataPropertyName=  "chukouwendugao"}
           ,new DataGridViewTextBoxColumn { HeaderText = "超压报警", Name = "chaoya" ,DataPropertyName=  "chaoya"}
           ,new DataGridViewTextBoxColumn { HeaderText = "极限低水位报警", Name = "jixiandishuiwei" ,DataPropertyName=  "jixiandishuiwei"}
           ,new DataGridViewTextBoxColumn { HeaderText = "低水位报警", Name = "dishuiwei" ,DataPropertyName= "dishuiwei" }
           ,new DataGridViewTextBoxColumn { HeaderText = "高水位报警", Name = "gaoshuiwei" ,DataPropertyName= "gaoshuiwei"}
           ,new DataGridViewTextBoxColumn { HeaderText = "水位信号逻辑错报警", Name = "shuiweixinhaoluojicuo" ,DataPropertyName="shuiweixinhaoluojicuo" }
           ,new DataGridViewTextBoxColumn { HeaderText = "炉壁温度高报警", Name = "lubiwendugao",DataPropertyName=   "lubiwendugao"}
           ,new DataGridViewTextBoxColumn { HeaderText = "负压蒸汽温度高报警", Name = "fuyazhengqiwendugao" ,DataPropertyName="fuyazhengqiwendugao" }
           ,new DataGridViewTextBoxColumn { HeaderText = "燃烧器故障报警", Name = "ranshaoqiguzhang" ,DataPropertyName=  "ranshaoqiguzhang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "燃气泄漏报警", Name = "ranqixielou",DataPropertyName=  "ranqixielou" }
           ,new DataGridViewTextBoxColumn { HeaderText = "燃气压力低报警", Name = "ranqiyalidi" ,DataPropertyName= "ranqiyalidi"}
           ,new DataGridViewTextBoxColumn { HeaderText = "燃气压力异常报警", Name = "ranqiyaliyichang" ,DataPropertyName= "ranqiyaliyichang" }
           ,new DataGridViewTextBoxColumn { HeaderText = "燃气压力高报警", Name = "ranqiyaligao" ,DataPropertyName=  "ranqiyaligao"}
           ,new DataGridViewTextBoxColumn { HeaderText = "给水变频器故障报警", Name = "jishuibianpinqiguzhang" ,DataPropertyName= "jishuibianpinqiguzhang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "循环变频器故障报警", Name = "xunhuanbianpinqiguzhang" ,DataPropertyName=  "xunhuanbianpinqiguzhang" }
           ,new DataGridViewTextBoxColumn { HeaderText = "引风变频器故障报警", Name = "yinfengbianpinqiguzhang" ,DataPropertyName=  "yinfengbianpinqiguzhang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "鼓风变频器故障报警", Name = "gufengbianpinqiguzhang" ,DataPropertyName=  "gufengbianpinqiguzhang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "二次鼓风变频器故障报警", Name = "ecigufengbianpinqiguzhang" ,DataPropertyName="ecigufengbianpinqiguzhang" }
           ,new DataGridViewTextBoxColumn { HeaderText = "炉排变频器故障报警", Name = "lupaibianpinqiguzhang" ,DataPropertyName= "lupaibianpinqiguzhang" }
           ,new DataGridViewTextBoxColumn { HeaderText = "给水泵故障报警", Name = "jishuibengguzhang" ,DataPropertyName=  "jishuibengguzhang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "循环泵故障报警", Name = "xunhuanbengguzhang" ,DataPropertyName=  "xunhuanbengguzhang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "欠压报警（循环系统）", Name = "xunhuanxitongqianya" ,DataPropertyName= "xunhuanxitongqianya"}
           ,new DataGridViewTextBoxColumn { HeaderText = "低电压报警", Name = "didianya",DataPropertyName=  "didianya" }
           ,new DataGridViewTextBoxColumn { HeaderText = "高电压报警", Name = "gaodianya" ,DataPropertyName= "gaodianya" }
           ,new DataGridViewTextBoxColumn { HeaderText = "缺相报警", Name = "quexiang" ,DataPropertyName= "quexiang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "漏电报警", Name = "loudian" ,DataPropertyName= "loudian"}
           ,new DataGridViewTextBoxColumn { HeaderText = "变送器过压保护", Name = "biansongqiguoyabaohu" ,DataPropertyName= "biansongqiguoyabaohu" }
           ,new DataGridViewTextBoxColumn { HeaderText = "关键参数异常", Name = "guanjiancanshuyichang",DataPropertyName=  "guanjiancanshuyichang" }
           ,new DataGridViewTextBoxColumn { HeaderText = "设定参数异常", Name = "shedingcanshuyichang",DataPropertyName=  "shedingcanshuyichang"}
           ,new DataGridViewTextBoxColumn { HeaderText = "时钟故障", Name = "shizhongguzhang",DataPropertyName=  "shizhongguzhang" }
           ,new DataGridViewTextBoxColumn { HeaderText = "存储器故障", Name = "cunchuqiguzhang" ,DataPropertyName="cunchuqiguzhang" }
           ,new DataGridViewTextBoxColumn { HeaderText = "外部连锁报警", Name = "waibuliansuo",DataPropertyName=   "waibuliansuo"}
           ,new DataGridViewTextBoxColumn { HeaderText = "缺油报警", Name = "queyou",DataPropertyName=  "queyou" }
           ,new DataGridViewTextBoxColumn { HeaderText = "低油位报警", Name = "diyouwei" ,DataPropertyName=  "diyouwei"}
           ,new DataGridViewTextBoxColumn { HeaderText = "本体排烟温度高报警", Name = "bentipaiyanwendugao" ,DataPropertyName=  "bentipaiyanwendugao"}
           ,new DataGridViewTextBoxColumn { HeaderText = "本体排烟温度", Name = "bentipaiyanwenduerror" ,DataPropertyName= "bentipaiyanwenduerror"}
           ,new DataGridViewTextBoxColumn { HeaderText = "排烟温度", Name = "paiyanwenduerror" ,DataPropertyName= "paiyanwenduerror"}
           ,new DataGridViewTextBoxColumn { HeaderText = "炉水温度", Name = "lushuiwenduerror" ,DataPropertyName= "lushuiwenduerror"}
           ,new DataGridViewTextBoxColumn { HeaderText = "出口温度", Name = "chukouwenduerror" ,DataPropertyName="chukouwenduerror" }
           ,new DataGridViewTextBoxColumn { HeaderText = "入口温度", Name = "rukouwenduerror",DataPropertyName=  "rukouwenduerror" }
           ,new DataGridViewTextBoxColumn { HeaderText = "节能器出口温度", Name = "jienengqichukouwenduerror",DataPropertyName=  "jienengqichukouwenduerror" }
           ,new DataGridViewTextBoxColumn { HeaderText = "节能器入口温度", Name = "jienengqirukouwenduerror",DataPropertyName= "jienengqirukouwenduerror" }
           ,new DataGridViewTextBoxColumn { HeaderText = "给水温度", Name = "jishuiwenduerror" ,DataPropertyName= "jishuiwenduerror"}
           ,new DataGridViewTextBoxColumn { HeaderText = "炉膛温度", Name = "lutangwenduerror" ,DataPropertyName= "lutangwenduerror" }
           ,new DataGridViewTextBoxColumn { HeaderText = "炉膛出口温度", Name = "lutangchukouwenduerror",DataPropertyName=  "lutangchukouwenduerror" }
           ,new DataGridViewTextBoxColumn { HeaderText = "炉壁温度", Name = "lubiwenduerror",DataPropertyName=  "lubiwenduerror" }
           ,new DataGridViewTextBoxColumn { HeaderText = "燃料温度", Name = "ranliaowenduerror" ,DataPropertyName=  "ranliaowenduerror"}
           ,new DataGridViewTextBoxColumn { HeaderText = "热风温度（空预器出口）", Name = "kongyuqichukourefengwenduerror",DataPropertyName=  "kongyuqichukourefengwenduerror"}
           ,new DataGridViewTextBoxColumn { HeaderText = "负压蒸汽温度", Name = "fuyazhengqiwenduerror" ,DataPropertyName= "fuyazhengqiwenduerror"}
           ,new DataGridViewTextBoxColumn { DataPropertyName = "guorezhengqiwenduerror" ,HeaderText = "过热蒸汽温度", Name = "guorezhengqiwenduerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "huilu1wenduerror" , HeaderText = "回路1温度", Name = "huilu1wenduerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "huilu2wenduerror" , HeaderText = "回路2温度", Name = "huilu2wenduerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "huilu3wenduerror"   , HeaderText = "回路3温度", Name = "huilu3wenduerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "huilu4wenduerror"  , HeaderText = "回路4温度", Name = "huilu4wenduerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "huilu5wenduerror" , HeaderText = "回路5温度", Name = "huilu5wenduerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shiwaiwenduerror" , HeaderText = "室外温度", Name = "shiwaiwenduerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "zhengqiyalierror"  , HeaderText = "蒸汽压力", Name = "zhengqiyalierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jishuiyalierror"  , HeaderText = "给水压力", Name = "jishuiyalierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "chukouyalierror" , HeaderText = "出口压力", Name = "chukouyalierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "rukouyalierror" , HeaderText = "入口压力", Name = "rukouyalierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lutangyalierror" , HeaderText = "炉膛压力", Name = "lutangyalierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "lutangchukouyalierror"   , HeaderText = "炉膛出口压力", Name = "lutangchukouyalierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ranqiyalierror" , HeaderText = "燃气压力", Name = "ranqiyalierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yicifengyaerror" , HeaderText = "一次风压", Name = "yicifengyaerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ecifengyaerror"  , HeaderText = "二次风压", Name = "ecifengyaerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "shunshiranliaoliangerror"   , HeaderText = "燃料量（瞬时值）", Name = "shunshiranliaoliangerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "shunshizhengqiliuliangerror" , HeaderText = "蒸汽流量（瞬时值）", Name = "shunshizhengqiliuliangerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shunshijishuiliuliangerror" , HeaderText = "给水流量（瞬时值）", Name = "shunshijishuiliuliangerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="shunshixunhuanliuliangerror"   , HeaderText = "循环流量（瞬时值）", Name = "shunshixunhuanliuliangerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="shunshibushuiliuliangerror"   , HeaderText = "补水流量（瞬时值）", Name = "shunshibushuiliuliangerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "guoluyeweierror" , HeaderText = "锅炉液位", Name = "guoluyeweierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shuixiangyeweierror" , HeaderText = "水箱液位", Name = "shuixiangyeweierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "paiyanyanghanliangerror" , HeaderText = "排烟氧含量", Name = "paiyanyanghanliangerror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lupaisudufankuierror"  , HeaderText = "炉排速度反馈", Name = "lupaisudufankuierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yinfengshuchufankuierror"  , HeaderText = "引风输出反馈", Name = "yinfengshuchufankuierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gufengshuchufankuierror"  , HeaderText = "鼓风输出反馈", Name = "gufengshuchufankuierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="jishuishuchufankuierror"  , HeaderText = "给水输出反馈", Name = "jishuishuchufankuierror" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jixiandishuiweibaojingdianji"  , HeaderText = "极限低水位报警电极（缺水保护）", Name = "jixiandishuiweibaojingdianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "dishuiweibaojingdianji" , HeaderText = "低水位报警电极", Name = "dishuiweibaojingdianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="dishuiweidianji"   , HeaderText = "低水位电极", Name = "dishuiweidianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "zhongshuiweidianji" , HeaderText = "中水位电极", Name = "zhongshuiweidianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gaoshuiweidianji" , HeaderText = "高水位电极", Name = "gaoshuiweidianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gaoshuiweibaojingdianji" , HeaderText = "高水位报警电极", Name = "gaoshuiweibaojingdianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="shuixiangdiweidianji"  , HeaderText = "水箱低位电极", Name = "shuixiangdiweidianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shuixianggaoweidianji"  , HeaderText = "水箱高位电极", Name = "shuixianggaoweidianji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jixiandiyeweibaojingxinhao" , HeaderText = "极限低液位报警信号（干接点）", Name = "jixiandiyeweibaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "dibaojingxinhao" , HeaderText = "低报警信号（干接点）", Name = "dibaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "kongbengxinhao" , HeaderText = "控泵信号（干接点）", Name = "kongbengxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gaobaojingxinhao"  , HeaderText = "高报警信号（干接点）", Name = "gaobaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "chaoyabaojingxinhao" , HeaderText = "超压报警信号", Name = "chaoyabaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "fuhediaojieyalixinhao" , HeaderText = "负荷调节压力信号", Name = "fuhediaojieyalixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "qitingkongzhiyalixinhao"  , HeaderText = "启停控制压力信号", Name = "qitingkongzhiyalixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yalibiaodizhen" , HeaderText = "压力表低针", Name = "yalibiaodizhen" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yalibiaogaozhen" , HeaderText = "压力表高针", Name = "yalibiaogaozhen" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lubichaowenxinhao" , HeaderText = "炉壁超温信号", Name = "lubichaowenxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ranshaoqiguzhangbaojingxinhao" , HeaderText = "燃烧器故障报警信号", Name = "ranshaoqiguzhangbaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ranqixieloubaojingxinhao" , HeaderText = "燃气泄漏报警信号", Name = "ranqixieloubaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ranqiyalidibaojingxinhao"  , HeaderText = "燃气压力低报警信号", Name = "ranqiyalidibaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ranqiyaliyichangbaojingxinhao"  , HeaderText = "燃气压力异常报警信号", Name = "ranqiyaliyichangbaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ranqiyaligaobaojingxinhao" , HeaderText = "燃气压力高报警信号", Name = "ranqiyaligaobaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "xunhuanbengdongzuofankuixinhao"  , HeaderText = "循环泵动作反馈信号（主）", Name = "xunhuanbengdongzuofankuixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "xunhuanbengdongzuofankuixinhaobei" , HeaderText = "循环泵动作反馈信号（备）", Name = "xunhuanbengdongzuofankuixinhaobei" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jishuibengdongzuofankuixinhao" , HeaderText = "给水泵动作反馈信号（主）", Name = "jishuibengdongzuofankuixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jishuibengdongzuofankuixinhaobei" , HeaderText = "给水泵动作反馈信号（备）", Name = "jishuibengdongzuofankuixinhaobei" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="yinfengjidongzuofankuixinhao"  , HeaderText = "引风机动作反馈信号", Name = "yinfengjidongzuofankuixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "gufengjidongzuofankuixinhao"  , HeaderText = "鼓风机动作反馈信号", Name = "gufengjidongzuofankuixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =   "ecigufengjidongzuofankuixinhao", HeaderText = "二次鼓风机动作反馈信号", Name = "ecigufengjidongzuofankuixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "chuzhajidongzuofankuixinhao" , HeaderText = "出渣机动作反馈信号", Name = "chuzhajidongzuofankuixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jishuibianpinqiguzhangxinhao" , HeaderText = "给水变频器故障信号", Name = "jishuibianpinqiguzhangxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "yinfengbianpinqiguzhangxinhao" , HeaderText = "引风变频器故障信号", Name = "yinfengbianpinqiguzhangxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gufengbianpinqiguzhangxinhao" , HeaderText = "鼓风变频器故障信号", Name = "gufengbianpinqiguzhangxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "lupaibianpinqiguzhangxinhao" , HeaderText = "炉排变频器故障信号", Name = "lupaibianpinqiguzhangxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yandaodiefafankuixinhao" , HeaderText = "烟道蝶阀反馈信号", Name = "yandaodiefafankuixinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "didianyabaojingxinhao" , HeaderText = "低电压报警信号", Name = "didianyabaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gaodianyabaojingxinhao" , HeaderText = "高电压报警信号", Name = "gaodianyabaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "quexiangbaojingxinhao" , HeaderText = "缺相报警信号", Name = "quexiangbaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "loudianbaojingxinhao", HeaderText = "漏电报警信号", Name = "loudianbaojingxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "queshuidianji2" , HeaderText = "缺水电极2", Name = "queshuidianji2" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "waibuliansuoxinhao"  , HeaderText = "外部连锁信号", Name = "waibuliansuoxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "chaodiyabaohuxinhao" , HeaderText = "超低压保护信号", Name = "chaodiyabaohuxinhao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ranshaoqiqiting" , HeaderText = "燃烧器启停", Name = "ranshaoqiqiting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ranshaoqidahuo" , HeaderText = "燃烧器大火", Name = "ranshaoqidahuo" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ranshaoqisanduanhuo" , HeaderText = "燃烧器三段火", Name = "ranshaoqisanduanhuo" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="ranshaoqihuolizengjia"  , HeaderText = "燃烧器火力增加", Name = "ranshaoqihuolizengjia" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ranshaoqihuolijianshao"  , HeaderText = "燃烧器火力减少", Name = "ranshaoqihuolijianshao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jishuibeng"   , HeaderText = "给水泵（主）", Name = "jishuibeng" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jishuibengbei" , HeaderText = "给水泵（备）", Name = "jishuibengbei" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jishuiliangzengjia" , HeaderText = "给水量增加", Name = "jishuiliangzengjia" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jishuiliangjianshao" , HeaderText = "给水量减少", Name = "jishuiliangjianshao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "xunhuanbeng" , HeaderText = "循环泵（主）", Name = "xunhuanbeng" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "xunhuanbengbei" , HeaderText = "循环泵（备）", Name = "xunhuanbengbei" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "baojingshuchu" , HeaderText = "报警输出", Name = "baojingshuchu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu1" , HeaderText = "加热组1", Name = "jiarezu1" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu2" , HeaderText = "加热组2", Name = "jiarezu2" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu3"  , HeaderText = "加热组3", Name = "jiarezu3" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu4" , HeaderText = "加热组4", Name = "jiarezu4" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu5"  , HeaderText = "加热组5", Name = "jiarezu5" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu6"  , HeaderText = "加热组6", Name = "jiarezu6" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu7" , HeaderText = "加热组7", Name = "jiarezu7" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu8" , HeaderText = "加热组8", Name = "jiarezu8" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu9"  , HeaderText = "加热组9", Name = "jiarezu9" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu10" , HeaderText = "加热组10", Name = "jiarezu10" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu11" , HeaderText = "加热组11", Name = "jiarezu11" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu12" , HeaderText = "加热组12", Name = "jiarezu12" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu13" , HeaderText = "加热组13", Name = "jiarezu13" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu14" , HeaderText = "加热组14", Name = "jiarezu14" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu15" , HeaderText = "加热组15", Name = "jiarezu15" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu16" , HeaderText = "加热组16", Name = "jiarezu16" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu17" , HeaderText = "加热组17", Name = "jiarezu17" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu18" , HeaderText = "加热组18", Name = "jiarezu18" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu19" , HeaderText = "加热组19", Name = "jiarezu19" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu20" , HeaderText = "加热组20", Name = "jiarezu20" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu21" , HeaderText = "加热组21", Name = "jiarezu21" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu22" , HeaderText = "加热组22", Name = "jiarezu22" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu23" , HeaderText = "加热组23", Name = "jiarezu23" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu24"  , HeaderText = "加热组24", Name = "jiarezu24" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu25"  , HeaderText = "加热组25", Name = "jiarezu25" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jiarezu26" , HeaderText = "加热组26", Name = "jiarezu26" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu27" , HeaderText = "加热组27", Name = "jiarezu27" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu28" , HeaderText = "加热组28", Name = "jiarezu28" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu29" , HeaderText = "加热组29", Name = "jiarezu29" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jiarezu30" , HeaderText = "加热组30", Name = "jiarezu30" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="yinfengji"   , HeaderText = "引风机", Name = "yinfengji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yinfengliangzengjia" , HeaderText = "引风量增加", Name = "yinfengliangzengjia" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yinfengliangjianshao" , HeaderText = "引风量减少", Name = "yinfengliangjianshao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gufengji" , HeaderText = "鼓风机", Name = "gufengji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gufengliangzengjia" , HeaderText = "鼓风量增加", Name = "gufengliangzengjia" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gufengliangjianshao" , HeaderText = "鼓风量减少", Name = "gufengliangjianshao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ecigufengji"  , HeaderText = "二次鼓风机", Name = "ecigufengji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ecigufengliangzengjia" , HeaderText = "二次鼓风量增加", Name = "ecigufengliangzengjia" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="ecigufengliangjianshao"   , HeaderText = "二次鼓风量减少", Name = "ecigufengliangjianshao" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "lupaihuojinliaojizhengzhuan" , HeaderText = "炉排（或进料机）正转", Name = "lupaihuojinliaojizhengzhuan" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lupaifanzhuan"  , HeaderText = "炉排反转", Name = "lupaifanzhuan" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "chuzhaji"  , HeaderText = "出渣机", Name = "chuzhaji" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "dianhuoqi"  , HeaderText = "点火器", Name = "dianhuoqi" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =   "jiayaobeng", HeaderText = "加药泵", Name = "jiayaobeng" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "paiwufa"  , HeaderText = "排污阀", Name = "paiwufa" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "bentipaiyanwendu" , HeaderText = "本体排烟温度", Name = "bentipaiyanwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "paiyanwendu"  , HeaderText = "排烟温度", Name = "paiyanwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lushuiwendu" , HeaderText = "炉水温度", Name = "lushuiwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "chukouwendu" , HeaderText = "出口温度", Name = "chukouwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "rukouwendu" , HeaderText = "入口温度", Name = "rukouwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "jienengqichukouwendu"  , HeaderText = "节能器出口温度", Name = "jienengqichukouwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jienengqirukouwendu"  , HeaderText = "节能器入口温度", Name = "jienengqirukouwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jishuiwendu" , HeaderText = "给水温度", Name = "jishuiwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lutangwendu"  , HeaderText = "炉膛温度", Name = "lutangwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="lutangchukouwendu"  , HeaderText = "炉膛出口温度", Name = "lutangchukouwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "lubiwendu"  , HeaderText = "炉壁温度", Name = "lubiwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ranliaowendu"  , HeaderText = "燃料温度", Name = "ranliaowendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "kongyuqichukourefengwendu" , HeaderText = "热风温度（空预器出口）", Name = "kongyuqichukourefengwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "fuyazhengqiwendu" , HeaderText = "负压蒸汽温度", Name = "fuyazhengqiwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "guorezhengqiwendu" , HeaderText = "过热蒸汽温度", Name = "guorezhengqiwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "huilu1wendu" , HeaderText = "回路1温度", Name = "huilu1wendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "huilu2wendu" , HeaderText = "回路2温度", Name = "huilu2wendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "huilu3wendu" , HeaderText = "回路3温度", Name = "huilu3wendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "huilu4wendu"  , HeaderText = "回路4温度", Name = "huilu4wendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "huilu5wendu" , HeaderText = "回路5温度", Name = "huilu5wendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shiwaiwendu" , HeaderText = "室外温度", Name = "shiwaiwendu" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "zhengqiyali" , HeaderText = "蒸汽压力", Name = "zhengqiyali" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="jishuiyali"  , HeaderText = "给水压力", Name = "jishuiyali" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "chukouyali"  , HeaderText = "出口压力", Name = "chukouyali" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "rukouyali" , HeaderText = "入口压力", Name = "rukouyali" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "lutangyali"  , HeaderText = "炉膛压力", Name = "lutangyali" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lutangchukouyali" , HeaderText = "炉膛出口压力", Name = "lutangchukouyali" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ranqiyali" , HeaderText = "燃气压力", Name = "ranqiyali" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "yicifengya" , HeaderText = "一次风压", Name = "yicifengya" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "ecifengya" , HeaderText = "二次风压", Name = "ecifengya" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shunshiranliaoliang" , HeaderText = "燃料量（瞬时值）", Name = "shunshiranliaoliang" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shunshizhengqiliuliang" , HeaderText = "蒸汽流量（瞬时值）", Name = "shunshizhengqiliuliang" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "shunshijishuiliuliang" , HeaderText = "给水流量（瞬时值）", Name = "shunshijishuiliuliang" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "shunshixunhuanliuliang" , HeaderText = "循环流量（瞬时值）", Name = "shunshixunhuanliuliang" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="shunshibushuiliuliang"  , HeaderText = "补水流量（瞬时值）", Name = "shunshibushuiliuliang" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "guoluyewei"  , HeaderText = "锅炉液位", Name = "guoluyewei" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "shuixiangyewei"   , HeaderText = "水箱液位", Name = "shuixiangyewei" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "paiyanyanghanliang" , HeaderText = "排烟氧含量", Name = "paiyanyanghanliang" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lupaisudufankui" , HeaderText = "炉排速度反馈", Name = "lupaisudufankui" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yinfengshuchufankui" , HeaderText = "引风输出反馈", Name = "yinfengshuchufankui" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "gufengshuchufankui"  , HeaderText = "鼓风输出反馈", Name = "gufengshuchufankui" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="jishuishuchufankui"  , HeaderText = "给水输出反馈", Name = "jishuishuchufankui" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "ranshaoshuchuliangSetting"  , HeaderText = "燃烧输出量", Name = "ranshaoshuchuliangSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "xunhuanshuchuliangSetting" , HeaderText = "循环输出量", Name = "xunhuanshuchuliangSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "jishuishuchuliangSetting"  , HeaderText = "给水输出量", Name = "jishuishuchuliangSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "yinfengshuchuliangSetting"  , HeaderText = "引风输出量", Name = "yinfengshuchuliangSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "gufengshuchuliangSetting" , HeaderText = "鼓风输出量", Name = "gufengshuchuliangSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="ecigufengshuchuliangSetting"  , HeaderText = "二次鼓风输出量", Name = "ecigufengshuchuliangSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "lupaihuojinliaoshuchuliangSetting" , HeaderText = "炉排（或进料）输出量", Name = "lupaihuojinliaoshuchuliangSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "paiyanwenduSetting" , HeaderText = "排烟温度", Name = "paiyanwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "baojingwenduSetting"  , HeaderText = "报警温度", Name = "baojingwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "tingluwenduSetting" , HeaderText = "停炉温度", Name = "tingluwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "mubiaowenduSetting" , HeaderText = "目标温度", Name = "mubiaowenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="qiluwenduSetting"  , HeaderText = "启炉温度", Name = "qiluwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "zhuanhuohuichaSetting"  , HeaderText = "转火回差", Name = "zhuanhuohuichaSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "qiluhuichaSetting"  , HeaderText = "启炉回差", Name = "qiluhuichaSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "kaibengwenduSetting"  , HeaderText = "开泵温度", Name = "kaibengwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "guanbengwenduSetting"   , HeaderText = "关泵温度", Name = "guanbengwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "baojingyaliSetting" , HeaderText = "报警压力", Name = "baojingyaliSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="tingluyaliSetting"  , HeaderText = "停炉压力", Name = "tingluyaliSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "mubiaoyaliSetting" , HeaderText = "目标压力", Name = "mubiaoyaliSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="qiluyaliSetting"  , HeaderText = "启炉压力", Name = "qiluyaliSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "zhuanhuohuichayaliSetting" , HeaderText = "转火回差（压力）", Name = "zhuanhuohuichayaliSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "qiluhuichayaliSetting"  , HeaderText = "启炉回差（压力）", Name = "qiluhuichayaliSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "qianyanshiSetting" , HeaderText = "前延时", Name = "qianyanshiSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "houyanshiSetting"  , HeaderText = "后延时", Name = "houyanshiSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "qianchuisaoSetting"  , HeaderText = "前吹扫", Name = "qianchuisaoSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "houchuisaoSetting" , HeaderText = "后吹扫", Name = "houchuisaoSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName ="lubibaojingwenduSetting"  , HeaderText = "炉壁报警温度", Name = "lubibaojingwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "lutangchukoubaojingwenduSetting"  , HeaderText = "炉膛出口报警温度", Name = "lutangchukoubaojingwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "baohuwenduSetting" , HeaderText = "保护温度", Name = "baohuwenduSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "bentipaiyanwendubaojingzhiSetting" , HeaderText = "本体排烟温度报警值", Name = "bentipaiyanwendubaojingzhiSetting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "qidongshijian1Setting" , HeaderText = "启动时间1（时 分）", Name = "qidongshijian1Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "tingzhishijian1Setting" , HeaderText = "停止时间1（时 分）", Name = "tingzhishijian1Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "qidongshijian2Setting"  , HeaderText = "启动时间2（时 分）", Name = "qidongshijian2Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "tingzhishijian2Setting" , HeaderText = "停止时间2（时 分）", Name = "tingzhishijian2Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "qidongshijian3Setting"  , HeaderText = "启动时间3（时 分）", Name = "qidongshijian3Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "tingzhishijian3Setting" , HeaderText = "停止时间3（时 分）", Name = "tingzhishijian3Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "qidongshijian4Setting" , HeaderText = "启动时间4（时 分）", Name = "qidongshijian4Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "tingzhishijian4Setting" , HeaderText = "停止时间4（时 分）", Name = "tingzhishijian4Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "qidongshijian5Setting"  , HeaderText = "启动时间5（时 分）", Name = "qidongshijian5Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "tingzhishijian5Setting" , HeaderText = "停止时间5（时 分）", Name = "tingzhishijian5Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName =  "qidongshijian6Setting" , HeaderText = "启动时间6（时 分）", Name = "qidongshijian6Setting" }
           ,new DataGridViewTextBoxColumn {DataPropertyName = "tingzhishijian6Setting" , HeaderText = "停止时间6（时 分）", Name = "tingzhishijian6Setting" }
                }
                );
            #endregion
        }
    }
}
