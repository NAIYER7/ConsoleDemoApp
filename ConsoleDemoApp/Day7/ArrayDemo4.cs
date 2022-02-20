using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoApp.Day7
{

    //Implementation IComparable interface
    class Product :IComparable<Product>
    {
        //data fields
        int _PId;
        string _Name;
        float _Price;
        string _Brand;
        //properties
        public int PId { get => _PId; set => _PId = value; }
        public string Name { get => _Name; set => _Name = value; }
        public float Price { get => _Price; set => _Price = value; }
        public string Brand { get => _Brand; set => _Brand = value; }

        public int CompareTo(Product other)
        {
            // return this._PId.CompareTo(other._PId);//>1,<-1,==0 //ascending
            return other._PId.CompareTo(this._PId);//>1,<-1,==0//descending

        }


        //Overriding ToString() Method to display
        public override string ToString()
        {
            return $"ID:{_PId}\tName:{_Name}\tBrand:{_Brand}\tPrice:{_Price}";
        }
    }

    class SortByNameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            return x.Name.CompareTo(y.Name);//Name property value comparison
        }
    }
    class SortByPriceComparer : IComparer
    {
        //public int Compare(object x, object y)
        //{
        //    return ((Product)x).Price.CompareTo(((Product)y).Price);
        //}
        bool sortBy;
        public SortByPriceComparer(bool sortBy=false)
        {
            this.sortBy = sortBy;
        }
        public int Compare(dynamic x, dynamic y)
        {
            if (!sortBy)
               return x.Price.CompareTo(y.Price);//Price property value comparison
            else
               return y.Price.CompareTo(x.Price);
        }
    }


    internal class ArrayDemo4
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
                                    {
                                        new Product(){PId=106,Name="Soap",Brand="Dettol",Price=18.0f },
                                        new Product(){PId=102,Name="Mobile",Brand="Nokia",Price=1200.0f },
                                        new Product(){PId=101,Name="Laptop",Brand="Dell",Price=45000.0f },
                                        new Product(){PId=103,Name="Biskit",Brand="ParleG",Price=5.0f },
                                        new Product(){PId=104,Name="Laptop",Brand="HP",Price=50000.0f }
                                    };
            Console.WriteLine("Product Details:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Array.Sort(products);//will sort data by id

            Console.WriteLine("Sorted Product Details:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Array.Sort(products,new SortByNameComparer());//will sort data by Name
            Console.WriteLine("Sorted Product By Name Details:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            // Array.Sort(products, new SortByPriceComparer());//will sort data by Price
            Array.Sort(products, new SortByPriceComparer(true));//will sort data by Price in desc
            Console.WriteLine("Sorted Product By Price Details:");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

        }
    }
}