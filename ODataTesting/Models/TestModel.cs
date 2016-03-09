using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ODataTesting.Models
{
    /// <summary>
    /// Test Data Model
    /// </summary>
    public class TestModel
    {
        /// <summary>Test Model Id</summary>
        [Key]
        public string TestModelId { get; set; }

        /// <summary>String Value</summary>
        public string TestString { get; set; }

        /// <summary>Int Value</summary>
        public int TestInt { get; set; }

        /// <summary>Double Value</summary>
        public double TestDouble { get; set; }

        /// <summary>Bool Value</summary>
        public bool TestBool { get; set; }

        /// <summary>Date Time Value</summary>
        public DateTime TestDateTime { get; set; }
    }
}