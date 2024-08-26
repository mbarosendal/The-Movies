using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Movies.Models;

namespace The_Movies.Repositories
{
    public class BiografRepository
    {
        public List<Biograf> Biografer { get; set; }

        public BiografRepository()
        {
            // testdata (3 biografer med hver deres CinemaHalls og PlayTimes)
            Biografer = new List<Biograf>
            {
                new Biograf
                {
                    CinemaName = "Nordisk Film",
                    Town = "Aarhus",
                    PhoneNumber = "12345678",
                    Email = "service@nordiskfilm.dk",
                    CinemaHalls = new List<Biografsal>
                    {
                        new Biografsal
                        {
                            Id = "1",
                            PlayTimes = new List<Spilletid>
                            {
                                new Spilletid { Day = DayOfWeek.Wednesday, StartTime = new DateTime(1, 1, 1, 12, 0, 0) }, // Friday at 12:00
                                new Spilletid { Day = DayOfWeek.Wednesday, StartTime = new DateTime(1, 1, 1, 16, 0, 0) }, // Friday at 16:00
                                new Spilletid { Day = DayOfWeek.Wednesday, StartTime = new DateTime(1, 1, 1, 21, 0, 0) }  // Friday at 21:00
                            },
                        },
                        new Biografsal
                        {
                            Id = "2",
                            PlayTimes = new List<Spilletid>
                            {
                                new Spilletid { Day = DayOfWeek.Thursday, StartTime = new DateTime(1, 1, 1, 12, 0, 0) }, // Friday at 12:00
                                new Spilletid { Day = DayOfWeek.Thursday, StartTime = new DateTime(1, 1, 1, 16, 0, 0) }, // Friday at 16:00
                                new Spilletid { Day = DayOfWeek.Thursday, StartTime = new DateTime(1, 1, 1, 21, 0, 0) }  // Friday at 21:00
                            }
                        }
                    }
                },

                new Biograf
                {
                    CinemaName = "Cinemaxx",
                    Town = "Randers",
                    PhoneNumber = "12345678",
                    Email = "info@cinemaxx.dk",
                   CinemaHalls = new List<Biografsal>
                    {
                        new Biografsal
                        {
                            Id = "1",
                            PlayTimes = new List<Spilletid>
                            {
                                new Spilletid { Day = DayOfWeek.Friday, StartTime = new DateTime(1, 1, 1, 12, 0, 0) }, // Friday at 12:00
                                new Spilletid { Day = DayOfWeek.Friday, StartTime = new DateTime(1, 1, 1, 16, 0, 0) }, // Friday at 16:00
                                new Spilletid { Day = DayOfWeek.Friday, StartTime = new DateTime(1, 1, 1, 21, 0, 0) }  // Friday at 21:00
                            },
                        },
                        new Biografsal
                        {
                            Id = "2",
                            PlayTimes = new List<Spilletid>
                            {
                                new Spilletid { Day = DayOfWeek.Saturday, StartTime = new DateTime(1, 1, 1, 12, 0, 0) }, // Friday at 12:00
                                new Spilletid { Day = DayOfWeek.Saturday, StartTime = new DateTime(1, 1, 1, 16, 0, 0) }, // Friday at 16:00
                                new Spilletid { Day = DayOfWeek.Saturday, StartTime = new DateTime(1, 1, 1, 21, 0, 0) }  // Friday at 21:00
                            }
                        },
                        new Biografsal
                        {
                            Id = "3",
                            PlayTimes = new List<Spilletid>
                            {
                                new Spilletid { Day = DayOfWeek.Sunday, StartTime = new DateTime(1, 1, 1, 12, 0, 0) }, // Friday at 12:00
                                new Spilletid { Day = DayOfWeek.Sunday, StartTime = new DateTime(1, 1, 1, 16, 0, 0) }, // Friday at 16:00
                                new Spilletid { Day = DayOfWeek.Sunday, StartTime = new DateTime(1, 1, 1, 21, 0, 0) }  // Friday at 21:00
                            }
                        }
                    }
                },

                new Biograf
                {
                    CinemaName = "Palads",
                    Town = "Odense",
                    PhoneNumber = "12345678",
                    Email = "kontakt@palads.dk",
                    CinemaHalls = new List<Biografsal>
                    {
                        new Biografsal
                        {
                            Id = "1",
                            PlayTimes = new List<Spilletid>
                            {
                                new Spilletid { Day = DayOfWeek.Monday, StartTime = new DateTime(1, 1, 1, 12, 0, 0) }, // Friday at 12:00
                                new Spilletid { Day = DayOfWeek.Monday, StartTime = new DateTime(1, 1, 1, 16, 0, 0) }, // Friday at 16:00
                                new Spilletid { Day = DayOfWeek.Monday, StartTime = new DateTime(1, 1, 1, 21, 0, 0) }  // Friday at 21:00
                            },
                        },
                        new Biografsal
                        {
                            Id = "2",
                            PlayTimes = new List<Spilletid>
                            {
                                new Spilletid { Day = DayOfWeek.Tuesday, StartTime = new DateTime(1, 1, 1, 12, 0, 0) }, // Friday at 12:00
                                new Spilletid { Day = DayOfWeek.Tuesday, StartTime = new DateTime(1, 1, 1, 16, 0, 0) }, // Friday at 16:00
                                new Spilletid { Day = DayOfWeek.Tuesday, StartTime = new DateTime(1, 1, 1, 21, 0, 0) }  // Friday at 21:00
                            }
                        }
                    }
                }
            };
        }

        public List<Biograf> GetAllBiografer()
        {
            return Biografer;
        }
    }
}
