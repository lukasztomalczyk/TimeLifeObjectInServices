
using Microsoft.AspNetCore.Mvc;
using Webaplikation2.Models;

namespace Webaplikation2 
{
 public class SingletonController : Controller 
 {
     private IClassMessage _classMessageObject;

     public SingletonController(IClassMessage _classMessage )
     {
         this._classMessageObject = _classMessage;
     }

     public IActionResult FirstInstance ()
    {
        int _hashCodeFromObject = _classMessageObject.GetHashCode();
        _classMessageObject._hashCodeOfObject = _hashCodeFromObject;
        _classMessageObject._nameOfInstanceObject = "First Instance";

        return View("SingletonView", _classMessageObject);
    }
    public IActionResult SecondInstance ()
    {
        int _hashCodeFromObject = _classMessageObject.GetHashCode();
        _classMessageObject._hashCodeOfObject = _hashCodeFromObject;
        _classMessageObject._nameOfInstanceObject = "Second Instance";
        
        return View("SingletonView", _classMessageObject);
    }

    public IActionResult ThirdInstance ()
    {
        int _hashCodeFromObject = _classMessageObject.GetHashCode();
        _classMessageObject._hashCodeOfObject = _hashCodeFromObject;
        _classMessageObject._nameOfInstanceObject = "Third Instance";
        
        return View("SingletonView", _classMessageObject);
    }
 }
}