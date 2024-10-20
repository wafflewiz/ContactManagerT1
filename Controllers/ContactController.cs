using ContactManagerT1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactManagerT1.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext context { get; set; }
    public ContactController(ContactContext ctx)
    {
        context = ctx;
    }
        
    [HttpGet]
        public IActionResult Details(int id)
        {
            // Retrieve the contact by the id from the database or service, including the Category
            var contact = context.Contacts
                .Include(c => c.Category) // Ensure you include the Category data
                .FirstOrDefault(c => c.Id == id);

            if (contact == null)
            {
                return NotFound();
            }

            return View(contact); // Pass the contact data to the view
        }
        [HttpGet]
    public IActionResult Add()
    {
        ViewBag.Action = "Add";
        ViewBag.Categories = context.Category.OrderBy(g => g.Name).ToList();
        return View("Edit", new Contact());
    }
    [HttpGet]
    public IActionResult Edit(int id)
    {
        ViewBag.Action = "Edit";
            ViewBag.Categories = context.Category.OrderBy(g => g.Name).ToList();
        var contact = context.Contacts.Find(id);
        return View(contact);
    }
    [HttpPost]
    public IActionResult Edit(Contact contact)
    {
        if (ModelState.IsValid)
        {
            if (contact.Id == 0)
                context.Contacts.Add(contact);
            else
                context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        else
        {
            ViewBag.Action = (contact.Id == 0) ? "Add" : "Edit";
            ViewBag.Categories = context.Category.OrderBy(g => g.CategoryId).ToList();
            return View(contact);
        }
    }
    [HttpGet]
    public IActionResult Delete(int id)
    {
        var contact = context.Contacts.Find(id);
        return View(contact);
    }
    [HttpPost]
    public IActionResult Delete(Contact contact)
    {
        context.Contacts.Remove(contact);
        context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }
}
}
