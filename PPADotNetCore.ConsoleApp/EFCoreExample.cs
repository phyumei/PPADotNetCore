﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPADotNetCore.ConsoleApp
{
    public class EFCoreExample
    {
        public void Read() 
        {
            AppDbContext db = new AppDbContext();
            var lst = db.Blogs.ToList();
            foreach (var item in lst)
            {
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);

            }
        }
    }
}