using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace QueryPractice
{
    [Table(Name = "cards")]
    public class Card
    {
        private int _Id;
        [Column(IsPrimaryKey = true, Storage = "_Id")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this._Id = value;
            }

        }

        private int _Type;
        [Column(Storage = "_Type")]
        public int Type
        {
            get
            {
                return this._Type;
            }
            set
            {
                this._Type = value;
            }
        }

        private string _Front;
        [Column(Storage = "_Front")]
        public string Front
        {
            get
            {
                return this._Front;
            }
            set
            {
                this._Front = value;
            }
        }

        private string _Back;
        [Column(Storage = "_Back")]
        public string Back
        {
            get
            {
                return this._Back;
            }
            set
            {
                this._Back = value;
            }
        }

        private bool _Known;
        [Column(Storage = "_Known")]
        public bool Known
        {
            get
            {
                return this._Known;
            }
            set
            {
                this._Known = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataContext db = new DataContext(@"c:\cards_new.sqlite");

            // Get a typed table to run queries.
            Table<Card> cards = db.GetTable<Card>();
            foreach(var card in cards)
            {
                Console.WriteLine(card.Id);
            }
        }
    }
}
