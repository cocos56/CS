using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电子商务系统
{
    public class Orderline
    {
        public int Ol_id{get;set;}
        public string Ol_name{get;set;}
        public int Ol_amount{get;set;}
        public double Ol_price{get;set;}
        public int Ol_sid{get;set;}
        public int Ol_cid{get;set;}
        public int Ol_oid{get;set;}
        public int Ol_gid{get;set;}
        public Orderline()
        {

        }
        public Orderline(string ol_name,double ol_price,int ol_amount,int ol_sid,int ol_cid,int ol_oid,int ol_gid)
        {
            this.Ol_name = ol_name;
            this.Ol_price = ol_price;
            this.Ol_amount = ol_amount;
            this.Ol_sid = ol_sid;
            this.Ol_cid = ol_cid;
            this.Ol_oid = ol_oid;
            this.Ol_gid = ol_gid;
        }
        public override string ToString()
        {
            return this.Ol_id + "\tname:" + this.Ol_name + "\tprice:" + this.Ol_price + "\tamount:" + this.Ol_amount + "\tol_sid:" + this.Ol_sid + "\tol_cid:" + this.Ol_cid + "\tol_oid:" + this.Ol_oid + "\tol_gid:" + this.Ol_gid;            
        }
    }
}
