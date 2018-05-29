using System;
using System.Data.SqlClient;

namespace Supplier
{
    public class zak
    {
        /// <summary>
        /// поставщик
        /// </summary>
        public string post { get; set; }
        /// <summary>
        /// заказ
        /// </summary>
        public string zakaz { get; set; }
        /// <summary>
        /// кол-во
        /// </summary>
        public int kol { get; set; }
        /// <summary>
        /// день заказа
        /// </summary>
        public string date_zak { get; set; } //обработать ввод даты
        /// <summary>
        /// статус
        /// </summary>
        public string state { get; set; }
        /// <summary>
        /// дата нового статуса
        /// </summary>
        public string date_new_stat { get; set; }
        /// <summary>
        /// процент оплаченного
        /// </summary>
        public float proc_opl { get; set; }
        /// <summary>
        /// цеха
        /// </summary>
        public enum cex { one, two, three }

        public cex c { get; set; } = new cex();

        public zak() { }

        public zak(string post, string zakaz, int kol, string date_zak, string state,
            string date_new_stat, float proc_opl, string c)
        {
            this.post = post;
            this.zakaz = zakaz;
            this.kol = kol;
            this.date_zak = date_zak;
            this.state = state;
            this.date_new_stat = date_new_stat;
            this.proc_opl = proc_opl;

            if (c == "Цех 1")
                this.c = cex.one;
            else if (c == "Цех 2")
                this.c = cex.two;
            else if (c == "Цех 2")
                this.c = cex.three;

        }

    }
}

