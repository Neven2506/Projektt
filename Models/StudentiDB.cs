using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projektt.Models
{
    
    public class StudentiDB
    {
        private List<Student> lista = new List<Student>();

        public StudentiDB()
        {  
            lista.Add(new Student()
            {
                ID = 1,
                Prezime = "Ivić",
                Spol = 'M',
                DatumRodjenja = new DateTime(1991, 02, 01),
                Oib = "12345678901",
                Ime = "Josip",
                RedovanStudent = true

            });
                        lista.Add(new Student()
                        {
                            ID = 2,
                            Prezime = "Sivić",
                            Spol = 'M',
                            DatumRodjenja = new DateTime(1991, 03, 01),
                            Oib = "12345678910",
                            Ime = "Ivo",
                            RedovanStudent = true

                        });
            lista.Add(new Student()
            {
                ID = 3,
                Prezime = "Andrić",
                Spol = 'M',
                DatumRodjenja = new DateTime(1991, 02, 02),
                Oib = "12345678911",
                Ime = "Ivan",
                RedovanStudent = true

            });
            lista.Add(new Student()
            {
                ID = 4,
                Prezime = "Mrvić",
                Spol = 'M',
                DatumRodjenja = new DateTime(1992, 02, 01),
                Oib = "12345678913",
                Ime="Petar",
                RedovanStudent = true

            });
        }
        public List<Student>VratiListu()
        {
            return lista;
        }
    }
}