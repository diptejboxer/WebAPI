using System;
using System.Collections.Generic;

namespace WebAPI.Contexts
{
    public partial class EntityFile
    {
        public int EntityFileId { get; set; }
        public string Description { get; set; }
        public DateTime FileDateTime { get; set; }
        public string FileName { get; set; }
        public int FileSizeBytes { get; set; }
        public byte[] FileBlob { get; set; }
        public string ExternalUri { get; set; }
        public int FileVersion { get; set; }
        public string ShowInlineNotes { get; set; }
        public string SystemCode { get; set; }
        public string IsActive { get; set; }
        public DateTime CreatedDatetime { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDatetime { get; set; }
        public string ModifiedBy { get; set; }
        public string CheckedOutToSam { get; set; }
        public string MigratedPath { get; set; }
        public DateTime? LastIndexAttemptDatetime { get; set; }
        public int LastIndexAttempts { get; set; }
        public string LastIndexSuccess { get; set; }
        public int? IndexLanguageId { get; set; }
    }
}
