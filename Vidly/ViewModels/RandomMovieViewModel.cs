using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public movie Movie { get; set; }

        public customer customer { get; set; }
        public List<customer> Customers { get; set; }

        public List<movie> Movies { get; set; }
    }
}