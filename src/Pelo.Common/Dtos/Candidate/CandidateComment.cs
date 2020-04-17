using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pelo.Common.Dtos.Candidate
{
    public class CandidateComment
    {
        public int Id { get; set; }

        public int CandidateStatusId { get; set; }

        public string Comment { get; set; }

        public IFormFileCollection Files { get; set; }
    }
}
