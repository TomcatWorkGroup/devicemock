﻿using System.Collections.Generic;

namespace BoilerDataTransmissionTest.Entities
{
    public class FiledNameMap
    {
        Dictionary<string, string> map = new Dictionary<string, string>()
        {
            {"deviceno", "设备编号"},
            {"nickname" , "设备名称"},
            {"rundays" , "运行天数"},
            {"runhours" , "运行小时数"},
            {"paiyanwendugao" , "排烟温度高报警"},
            {"lushuiwendugao" , "炉水温度高报警"},
            {"chukouwendugao" , "出口温度高报警"},
            {"chaoya" , "超压报警"},
            {"jixiandishuiwei" , "极限低水位报警"},
            {"dishuiwei" , "低水位报警"},
            {"gaoshuiwei" , "高水位报警"},
            {"shuiweixinhaoluojicuo" , "水位信号逻辑错报警"},
            {"lubiwendugao", "炉壁温度高报警"},
            {"fuyazhengqiwendugao" , "负压蒸汽温度高报警"},
            {"ranshaoqiguzhang" , "燃烧器故障报警"},
            {"ranqixielou", "燃气泄漏报警"},
            {"ranqiyalidi" , "燃气压力低报警"},
            {"ranqiyaliyichang" , "燃气压力异常报警"},
            {"ranqiyaligao" , "燃气压力高报警"},
            {"jishuibianpinqiguzhang" , "给水变频器故障报警"},
            {"xunhuanbianpinqiguzhang" , "循环变频器故障报警"},
            {"yinfengbianpinqiguzhang" , "引风变频器故障报警"},
            {"gufengbianpinqiguzhang" , "鼓风变频器故障报警"},
            {"ecigufengbianpinqiguzhang" , "二次鼓风变频器故障报警"},
            {"lupaibianpinqiguzhang" , "炉排变频器故障报警"},
            {"jishuibengguzhang" , "给水泵故障报警"},
            {"xunhuanbengguzhang" , "循环泵故障报警"},
            {"xunhuanxitongqianya" , "欠压报警（循环系统）"},
            {"didianya", "低电压报警"},
            {"gaodianya" , "高电压报警"},
            {"quexiang" , "缺相报警"},
            {"loudian" , "漏电报警"},
            {"biansongqiguoyabaohu" , "变送器过压保护"},
            {"guanjiancanshuyichang", "关键参数异常"},
            {"shedingcanshuyichang", "设定参数异常"},
            {"shizhongguzhang", "时钟故障"},
            {"cunchuqiguzhang" , "存储器故障"},
            {"waibuliansuo", "外部连锁报警"},
            {"queyou", "缺油报警"},
            {"diyouwei" , "低油位报警"},
            {"bentipaiyanwendugao" , "本体排烟温度高报警"},
            {"bentipaiyanwenduerror" , "本体排烟温度传感器故障"},
            {"paiyanwenduerror" , "排烟温度传感器故障"},
            {"lushuiwenduerror" , "炉水温度传感器故障"},
            {"chukouwenduerror" , "出口温度传感器故障"},
            {"rukouwenduerror", "入口温度传感器故障"},
            {"jienengqichukouwenduerror", "节能器出口温度传感器故障"},
            {"jienengqirukouwenduerror", "节能器入口温度传感器故障"},
            {"jishuiwenduerror" , "给水温度传感器故障"},
            {"lutangwenduerror" , "炉膛温度传感器故障"},
            {"lutangchukouwenduerror", "炉膛出口温度传感器故障"},
            {"lubiwenduerror", "炉壁温度传感器故障"},
            {"ranliaowenduerror" , "燃料温度传感器故障"},
            {"kongyuqichukourefengwenduerror", "热风温度（空预器出口）传感器故障"},
            {"fuyazhengqiwenduerror" , "负压蒸汽温度传感器故障"},
            {"guorezhengqiwenduerror" ,"过热蒸汽温度传感器故障"},
            {"huilu1wenduerror" , "回路1温度传感器故障"},
            {"huilu2wenduerror" , "回路2温度传感器故障"},
            {"huilu3wenduerror"   , "回路3温度传感器故障"},
            {"huilu4wenduerror"  , "回路4温度传感器故障"},
            {"huilu5wenduerror" , "回路5温度传感器故障"},
            {"shiwaiwenduerror" , "室外温度传感器故障"},
            {"zhengqiyalierror"  , "蒸汽压力传感器故障"},
            {"jishuiyalierror"  , "给水压力传感器故障"},
            {"chukouyalierror" , "出口压力传感器故障"},
            {"rukouyalierror" , "入口压力传感器故障"},
            {"lutangyalierror" , "炉膛压力传感器故障"},
            {"lutangchukouyalierror"   , "炉膛出口压力传感器故障"},
            {"ranqiyalierror" , "燃气压力传感器故障"},
            {"yicifengyaerror" , "一次风压传感器故障"},
            {"ecifengyaerror"  , "二次风压传感器故障"},
            {"shunshiranliaoliangerror"   , "燃料量（瞬时值）传感器故障"},
            {"shunshizhengqiliuliangerror" , "蒸汽流量（瞬时值）传感器故障"},
            {"shunshijishuiliuliangerror" , "给水流量（瞬时值）传感器故障"},
            {"shunshixunhuanliuliangerror"   , "循环流量（瞬时值）传感器故障"},
            {"shunshibushuiliuliangerror"   , "补水流量（瞬时值）传感器故障"},
            {"guoluyeweierror" , "锅炉液位传感器故障"},
            {"shuixiangyeweierror" , "水箱液位传感器故障"},
            {"paiyanyanghanliangerror" , "排烟氧含量传感器故障"},
            {"lupaisudufankuierror"  , "炉排速度反馈传感器故障"},
            {"yinfengshuchufankuierror"  , "引风输出反馈传感器故障"},
            {"gufengshuchufankuierror"  , "鼓风输出反馈传感器故障"},
            {"jishuishuchufankuierror"  , "给水输出反馈传感器故障"},
            {"jixiandishuiweibaojingdianji"  , "极限低水位报警电极（缺水保护）开关"},
            {"dishuiweibaojingdianji" , "低水位报警电极开关"},
            {"dishuiweidianji"   , "低水位电极开关"},
            {"zhongshuiweidianji" , "中水位电极开关"},
            {"gaoshuiweidianji" , "高水位电极开关"},
            {"gaoshuiweibaojingdianji" , "高水位报警电极开关"},
            {"shuixiangdiweidianji"  , "水箱低位电极开关"},
            {"shuixianggaoweidianji"  , "水箱高位电极开关"},
            {"jixiandiyeweibaojingxinhao" , "极限低液位报警信号（干接点）开关"},
            {"dibaojingxinhao" , "低报警信号（干接点）开关"},
            {"kongbengxinhao" , "控泵信号（干接点）开关"},
            {"gaobaojingxinhao"  , "高报警信号（干接点）开关"},
            {"chaoyabaojingxinhao" , "超压报警信号开关"},
            {"fuhediaojieyalixinhao" , "负荷调节压力信号开关"},
            {"qitingkongzhiyalixinhao"  , "启停控制压力信号开关"},
            {"yalibiaodizhen" , "压力表低针开关"},
            {"yalibiaogaozhen" , "压力表高针开关"},
            {"lubichaowenxinhao" , "炉壁超温信号开关"},
            {"ranshaoqiguzhangbaojingxinhao" , "燃烧器故障报警信号开关"},
            {"ranqixieloubaojingxinhao" , "燃气泄漏报警信号开关"},
            {"ranqiyalidibaojingxinhao"  , "燃气压力低报警信号开关"},
            {"ranqiyaliyichangbaojingxinhao"  , "燃气压力异常报警信号开关"},
            {"ranqiyaligaobaojingxinhao" , "燃气压力高报警信号开关"},
            {"xunhuanbengdongzuofankuixinhao"  , "循环泵动作反馈信号（主）开关"},
            {"xunhuanbengdongzuofankuixinhaobei" , "循环泵动作反馈信号（备）开关"},
            {"jishuibengdongzuofankuixinhao" , "给水泵动作反馈信号（主）开关"},
            {"jishuibengdongzuofankuixinhaobei" , "给水泵动作反馈信号（备）开关"},
            {"yinfengjidongzuofankuixinhao"  , "引风机动作反馈信号开关"},
            {"gufengjidongzuofankuixinhao"  , "鼓风机动作反馈信号开关"},
            {"ecigufengjidongzuofankuixinhao", "二次鼓风机动作反馈信号开关"},
            {"chuzhajidongzuofankuixinhao" , "出渣机动作反馈信号开关"},
            {"jishuibianpinqiguzhangxinhao" , "给水变频器故障信号开关"},
            {"yinfengbianpinqiguzhangxinhao" , "引风变频器故障信号开关"},
            {"gufengbianpinqiguzhangxinhao" , "鼓风变频器故障信号开关"},
            {"lupaibianpinqiguzhangxinhao" , "炉排变频器故障信号开关"},
            {"yandaodiefafankuixinhao" , "烟道蝶阀反馈信号开关"},
            {"didianyabaojingxinhao" , "低电压报警信号开关"},
            {"gaodianyabaojingxinhao" , "高电压报警信号开关"},
            {"quexiangbaojingxinhao" , "缺相报警信号开关"},
            {"loudianbaojingxinhao", "漏电报警信号开关"},
            {"queshuidianji2" , "缺水电极2开关"},
            {"waibuliansuoxinhao"  , "外部连锁信号开关"},
            {"chaodiyabaohuxinhao" , "超低压保护信号开关"},
            {"ranshaoqiqiting" , "燃烧器启停开关"},
            {"ranshaoqidahuo" , "燃烧器大火开关"},
            {"ranshaoqisanduanhuo" , "燃烧器三段火开关"},
            {"ranshaoqihuolizengjia"  , "燃烧器火力增加开关"},
            {"ranshaoqihuolijianshao"  , "燃烧器火力减少开关"},
            {"jishuibeng"   , "给水泵（主）开关"},
            {"jishuibengbei" , "给水泵（备）开关"},
            {"jishuiliangzengjia" , "给水量增加开关"},
            {"jishuiliangjianshao" , "给水量减少开关"},
            {"xunhuanbeng" , "循环泵（主）开关"},
            {"xunhuanbengbei" , "循环泵（备）开关"},
            {"baojingshuchu" , "报警输出开关"},
            {"jiarezu1" , "加热组1开关"},
            {"jiarezu2" , "加热组2开关"},
            {"jiarezu3"  , "加热组3开关"},
            {"jiarezu4" , "加热组4开关"},
            {"jiarezu5"  , "加热组5开关"},
            {"jiarezu6"  , "加热组6开关"},
            {"jiarezu7" , "加热组7开关"},
            {"jiarezu8" , "加热组8开关"},
            {"jiarezu9"  , "加热组9开关"},
            {"jiarezu10" , "加热组10开关"},
            {"jiarezu11" , "加热组11开关"},
            {"jiarezu12" , "加热组12开关"},
            {"jiarezu13" , "加热组13开关"},
            {"jiarezu14" , "加热组14开关"},
            {"jiarezu15" , "加热组15开关"},
            {"jiarezu16" , "加热组16开关"},
            {"jiarezu17" , "加热组17开关"},
            {"jiarezu18" , "加热组18开关"},
            {"jiarezu19" , "加热组19开关"},
            {"jiarezu20" , "加热组20开关"},
            {"jiarezu21" , "加热组21开关"},
            {"jiarezu22" , "加热组22开关"},
            {"jiarezu23" , "加热组23开关"},
            {"jiarezu24"  , "加热组24开关"},
            {"jiarezu25"  , "加热组25开关"},
            {"jiarezu26" , "加热组26开关"},
            {"jiarezu27" , "加热组27开关"},
            {"jiarezu28" , "加热组28开关"},
            {"jiarezu29" , "加热组29开关"},
            {"jiarezu30" , "加热组30开关"},
            {"yinfengji"   , "引风机开关"},
            {"yinfengliangzengjia" , "引风量增加开关"},
            {"yinfengliangjianshao" , "引风量减少开关"},
            {"gufengji" , "鼓风机开关"},
            {"gufengliangzengjia" , "鼓风量增加开关"},
            {"gufengliangjianshao" , "鼓风量减少开关"},
            {"ecigufengji"  , "二次鼓风机开关"},
            {"ecigufengliangzengjia" , "二次鼓风量增加开关"},
            {"ecigufengliangjianshao"   , "二次鼓风量减少开关"},
            {"lupaihuojinliaojizhengzhuan" , "炉排（或进料机）正转开关"},
            {"lupaifanzhuan"  , "炉排反转开关"},
            {"chuzhaji"  , "出渣机开关"},
            {"dianhuoqi"  , "点火器开关"},
            {"jiayaobeng", "加药泵开关"},
            {"paiwufa"  , "排污阀开关"},
            {"bentipaiyanwendu" , "本体排烟温度"},
            {"paiyanwendu"  , "排烟温度"},
            {"lushuiwendu" , "炉水温度"},
            {"chukouwendu" , "出口温度"},
            {"rukouwendu" , "入口温度"},
            {"jienengqichukouwendu"  , "节能器出口温度"},
            {"jienengqirukouwendu"  , "节能器入口温度"},
            {"jishuiwendu" , "给水温度"},
            {"lutangwendu"  , "炉膛温度"},
            {"lutangchukouwendu"  , "炉膛出口温度"},
            {"lubiwendu"  , "炉壁温度"},
            {"ranliaowendu"  , "燃料温度"},
            {"kongyuqichukourefengwendu" , "热风温度（空预器出口）"},
            {"fuyazhengqiwendu" , "负压蒸汽温度"},
            {"guorezhengqiwendu" , "过热蒸汽温度"},
            {"huilu1wendu" , "回路1温度"},
            {"huilu2wendu" , "回路2温度"},
            {"huilu3wendu" , "回路3温度"},
            {"huilu4wendu"  , "回路4温度"},
            {"huilu5wendu" , "回路5温度"},
            {"shiwaiwendu" , "室外温度"},
            {"zhengqiyali" , "蒸汽压力"},
            {"jishuiyali"  , "给水压力"},
            {"chukouyali"  , "出口压力"},
            {"rukouyali" , "入口压力"},
            {"lutangyali"  , "炉膛压力"},
            {"lutangchukouyali" , "炉膛出口压力"},
            {"ranqiyali" , "燃气压力"},
            {"yicifengya" , "一次风压"},
            {"ecifengya" , "二次风压"},
            {"shunshiranliaoliang" , "燃料量（瞬时值）"},
            {"shunshizhengqiliuliang" , "蒸汽流量（瞬时值）"},
            {"shunshijishuiliuliang" , "给水流量（瞬时值）"},
            {"shunshixunhuanliuliang" , "循环流量（瞬时值）"},
            {"shunshibushuiliuliang"  , "补水流量（瞬时值）"},
            {"guoluyewei"  , "锅炉液位"},
            {"shuixiangyewei"   , "水箱液位"},
            {"paiyanyanghanliang" , "排烟氧含量"},
            {"lupaisudufankui" , "炉排速度反馈"},
            {"yinfengshuchufankui" , "引风输出反馈"},
            {"gufengshuchufankui"  , "鼓风输出反馈"},
            {"jishuishuchufankui"  , "给水输出反馈"},
            {"ranshaoshuchuliangsetting"  , "燃烧输出量设置"},
            {"xunhuanshuchuliangsetting" , "循环输出量设置"},
            {"jishuishuchuliangsetting"  , "给水输出量设置"},
            {"yinfengshuchuliangsetting"  , "引风输出量设置"},
            {"gufengshuchuliangsetting" , "鼓风输出量设置"},
            {"ecigufengshuchuliangsetting"  , "二次鼓风输出量设置"},
            {"lupaihuojinliaoshuchuliangsetting" , "炉排（或进料）输出量设置"},
            {"paiyanwendusetting" , "排烟温度设置"},
            {"baojingwendusetting"  , "报警温度设置"},
            {"tingluwendusetting" , "停炉温度设置"},
            {"mubiaowendusetting" , "目标温度设置"},
            {"qiluwendusetting"  , "启炉温度设置"},
            {"zhuanhuohuichasetting"  , "转火回差设置"},
            {"qiluhuichasetting"  , "启炉回差设置"},
            {"kaibengwendusetting"  , "开泵温度设置"},
            {"guanbengwendusetting"   , "关泵温度设置"},
            {"baojingyalisetting" , "报警压力设置"},
            {"tingluyalisetting"  , "停炉压力设置"},
            {"mubiaoyalisetting" , "目标压力设置"},
            {"qiluyalisetting"  , "启炉压力设置"},
            {"zhuanhuohuichayalisetting" , "转火回差（压力）设置"},
            {"qiluhuichayalisetting"  , "启炉回差（压力）设置"},
            {"qianyanshisetting" , "前延时设置"},
            {"houyanshisetting"  , "后延时设置"},
            {"qianchuisaosetting"  , "前吹扫设置"},
            {"houchuisaosetting" , "后吹扫设置"},
            {"lubibaojingwendusetting"  , "炉壁报警温度设置"},
            {"lutangchukoubaojingwendusetting"  , "炉膛出口报警温度设置"},
            {"baohuwendusetting" , "保护温度设置"},
            {"bentipaiyanwendubaojingzhisetting" , "本体排烟温度报警值设置"},
            {"qidongshijian1setting" , "启动时间1（时 分）设置"},
            {"tingzhishijian1setting" , "停止时间1（时 分）设置"},
            {"qidongshijian2setting"  , "启动时间2（时 分）设置"},
            {"tingzhishijian2setting" , "停止时间2（时 分）设置"},
            {"qidongshijian3setting"  , "启动时间3（时 分）设置"},
            {"tingzhishijian3setting" , "停止时间3（时 分）设置"},
            {"qidongshijian4setting" , "启动时间4（时 分）设置"},
            {"tingzhishijian4setting" , "停止时间4（时 分）设置"},
            {"qidongshijian5setting"  , "启动时间5（时 分）设置"},
            {"tingzhishijian5setting" , "停止时间5（时 分）设置"},
            {"qidongshijian6setting" , "启动时间6（时 分）设置"},
            {"tingzhishijian6setting" , "停止时间6（时 分）设置"}
        };

        public string getName(string fieldName)
        {
            return map.ContainsKey(fieldName) ? map[fieldName] : string.Empty;
        }
    }
}