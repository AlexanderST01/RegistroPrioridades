using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
public class PrioridadesBLL
{
    private Context _context; 
    public PrioridadesBLL(Context context)
    {
        _context = context; 
    }
    public bool Existe(int PrioridadId ) 
    {
        return _context.Prioridades.Any(i => i.PrioridadId == PrioridadId);
    }
    public bool Insertar(Prioridades prioridades)
    {
        _context.Prioridades.Add(prioridades);
        int insertado = _context.SaveChanges();
        return insertado > 0;
    }
    public bool Modificar (Prioridades prioridades)
    {
        _context.Update(prioridades); 
        int modificado = _context.SaveChanges();
        return modificado > 0;
    }
    public bool Guardar (Prioridades prioridades)
    {
        if(!Existe(prioridades.PrioridadId))
            return Insertar(prioridades);
        else
            return Modificar(prioridades);
    }
    public bool Eliminar(Prioridades prioridades)
    {
        _context.Prioridades.Remove(prioridades);
        int eliminado = _context.SaveChanges();
        return eliminado > 0;
    }
    public Prioridades? Buscar(int PrioridadId)
    {
        return _context.Prioridades
                .AsNoTracking()
                .SingleOrDefault( i => i.PrioridadId == PrioridadId);
    }

}