using System;
using System.ComponentModel;

namespace Photos.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public int FilmRollId { get; set; }
        public short FrameNumber { get; set; }
        public decimal Aperture { get; set; }
        public decimal FocalLength { get; set; }
        public short ShutterSpeedNumerator { get; set; }
        public short ShutterSpeedDenominator { get; set; }
    }

    public class FilmRoll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short Iso { get; set; }
        public Format Format { get; set; }
        public DateTime Started { get; set; }
        public DateTime? Finished { get; set; }
    }

    public enum Format 
    {
        [Description("35mm")]
        ThirtyFive,

        [Description("Polaroid SX-70")]
        PolaroidSX70,

        [Description("Polaroid 600")]
        Polaroid600,
        
        [Description("120")]
        OneTwenty
    }
}