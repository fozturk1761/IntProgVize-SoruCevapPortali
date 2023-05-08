namespace sorucevapuyg.Controllers
{
    public class ServisControllerBase
    {

        #region Kullanici
        [HttpPost]
        [Route("kullaniciekle")]
        public IActionResult KullaniciEkle(Kullanici kullanici)
        {
            if (ModelState.IsValid)
            {
                _context.Kullanici.Add(kullanici);
                _context.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}