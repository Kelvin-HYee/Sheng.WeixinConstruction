﻿/*
********************************************************************
*
*    曹旭升（sheng.c）
*    E-mail: cao.silhouette@msn.com
*    QQ: 279060597
*    https://github.com/iccb1013
*    http://shengxunwei.com
*
*    © Copyright 2016
*
********************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    public class Campaign_MemberQRCodeBundle
    {
        public CampaignEntity Campaign
        {
            get;
            set;
        }

        public Campaign_MemberQRCodeEntity MemberQRCode
        {
            get;
            set;
        }

        public bool Empty
        {
            get
            {
                if (Campaign == null || MemberQRCode == null)
                    return true;
                else
                    return false;
            }
        }
    }
}
