﻿#nullable disable
using AutoMapper;
using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Controllers
{
    [Authorize(Roles = Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        private readonly ILeaveTypeRepository leaveTypesRepository;
        private readonly IMapper mapper;

        public LeaveTypesController(ILeaveTypeRepository leaveTypesRepository, IMapper mapper)
        {
            this.leaveTypesRepository = leaveTypesRepository;
            this.mapper = mapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveTypes = mapper.Map<List<LeaveTypeVM>>(await leaveTypesRepository.GetAllAsync());
            return View(leaveTypes);
        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var leaveType = await leaveTypesRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                await leaveTypesRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var leaveType = await leaveTypesRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }

            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                    await leaveTypesRepository.UpdateAsync(leaveType);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypesRepository.Exists(leaveTypeVM.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await leaveTypesRepository.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ActionName("Allocate")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AllocateLeave(int id)
        {
            throw new NotImplementedException();
        }
    }
}