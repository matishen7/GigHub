using GigHub.Dto;
using GigHub.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GigHub.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _context { get; set; }

        public AttendancesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_context.Attendances.Any(a => a.GigId == attendanceDto.GigId && a.AttendeeId == userId))
                return BadRequest("An attendance already exists.");

            var attendance = new Attendance()
            {
                GigId = attendanceDto.GigId,
                AttendeeId = User.Identity.GetUserId()
            };

            _context.Attendances.Add(attendance);
            _context.SaveChanges();
            return Ok();
        }
    }
}