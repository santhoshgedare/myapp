using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAppDAL.Model;

namespace MyAppDAL.Utility
{
    public class ResponseDTO
    {
        int _id;
        bool _valid;
        string _message;
        // string _bookedseats;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Msg
        {
            get { return _message; }
            set { _message = value; }
        }

        public bool Valid
        {
            get { return _valid; }
            set { _valid = value; }
        }

        //public string BookedSeats
        //{
        //    get { return _bookedseats; }
        //    set { _bookedseats = value; }
        //}

        public ResponseDTO(string defaultMessage)
        {
            Msg = defaultMessage;
            Valid = false;
        }

        /// <summary>
        /// Initializes the Success variable to 'false.'
        /// </summary>
        public ResponseDTO()
        {
            Valid = false;
        }

    }

    public class ListResponseDTO<DtoType> : ResponseDTO
    {
        public ListResponseDTO()
            : base()
        {
            Items = new List<DtoType>();
        }

        public ListResponseDTO(string defaultMessage)
            : base(defaultMessage)
        {
            Items = new List<DtoType>();
        }

        public List<DtoType> Items;

    }

    public class SingleItemResponseDTO<DtoType> : ResponseDTO where DtoType : new()
    {
        public SingleItemResponseDTO()
            : base()
        {
            Item = new DtoType();
        }

        public SingleItemResponseDTO(string defaultMessage)
            : base(defaultMessage)
        {
            Item = new DtoType();
        }
        public DtoType Item;
    }
}
