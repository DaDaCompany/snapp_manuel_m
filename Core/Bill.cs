﻿using ICore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Bill : IBill
    {
        /// <summary>
        /// The id of the Bill
        /// </summary>
        [MaxLength(36)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        /// <summary>
        /// the name of the project for the bill
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// the start date of the project
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// the enddate of the project for the bill
        /// </summary>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// the customer of the project for the bill
        /// </summary>
        [NotMapped]
        ICustomer IBill.ICustomer => (ICustomer)Customer;
        public Customer Customer { get; set; }
        public string CustomerId { get; set; }

    }
}
