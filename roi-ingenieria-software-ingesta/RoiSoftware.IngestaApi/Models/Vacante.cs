namespace RoiSoftware.IngestaApi.Models
{
    public class Vacante
    {
        // 1. Identificadores básicos
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Empresa { get; set; } = string.Empty;
        public string Plataforma { get; set; } = string.Empty; // LinkedIn, Indeed, etc.

        // 2. Variables Econométricas (Para el análisis del ROI)
        public decimal SueldoMaximo { get; set; }
        public decimal SueldoMinimo { get; set; }
        public string NivelIngles { get; set; } = string.Empty; // Inicial, Intermedio, Avanzado

        // 3. Tecnologías (Para medir el mercado)
        public string TecnologiasRequeridas { get; set; } = string.Empty; // React, C#, Python...

        public DateTime FechaExtraccion { get; set; } = DateTime.Now;
    }
}
