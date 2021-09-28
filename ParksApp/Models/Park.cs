using System;
using System.Text;
using System.Collections.Generic;
using static ParksApp.Models.Park.Amenity;

namespace ParksApp.Models
{
    public class Park
    {

        public int Id { get; set; }

        public string name { get; set; }

        public string Description1 { get; set; }

        public Dimension Size { get; set; }

        public Location Address { get; set; } = new Location();

        public List<Amenity> Amenities { get; set; } = new List<Amenity>();

        public class Dimension
        {

            public string Width { get; set; }

            public string Length { get; set; }


        }



        public class Amenity
        {
            public int Quantity { get; internal set; }
            public Types Type { get; internal set; }
            public string Description { get; internal set; }

            public enum Types
            {
                Swings,
                Slides,
                MoneyBar,
                Bathroom,
                Pool,
                Stakepark,
                IceRink


            }

            public enum Status
            {
               NotStarted = 0,
                Started = 1,
                Finished = 2
            }

            public enum Response
            {
                Success = 200,
                Redirect = 300,
                NotFound = 400
            }


        }

        public Types Type { get; set; }


        public int Quantity { get; set; }

        public string Description { get; set; }


     
    


            public class Location
            {
                
                public string StreetNumber { get; set; }

                public string Street { get; set; }

                public String City { get; set; }

                public string Province { get; set; }


                public string PostalCode { get; set; }


                public string Country { get; set; }

            }

        }


    }

