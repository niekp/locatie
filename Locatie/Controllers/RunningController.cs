﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Locatie.Repositories.Core;
using Locatie.Utils;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Locatie.Controllers
{
    public class RunningController : Controller
    {
        private readonly IRunRepository runRepository;
        private readonly ITagRepository tagRepository;

        public RunningController(
            IRunRepository runRepository,
            ITagRepository tagRepository
        )
        {
            this.runRepository = runRepository;
            this.tagRepository = tagRepository;
        }

        

        public async Task<IActionResult> Index()
        {
            var runs = await runRepository.GetRuns();
            return View(runs);
        }
    }
}
