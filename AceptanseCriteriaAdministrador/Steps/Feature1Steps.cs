using System;
using TechTalk.SpecFlow;

namespace AceptanseCriteriaAdministrador.Steps
{
    [Binding]
    public class Feature1Steps
    {
        [Given(@"que el usuario se encuentra en la vista de “Planes en Chreana”")]
        public void GivenQueElUsuarioSeEncuentraEnLaVistaDePlanesEnChreana()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"el usuario compre una membresia")]
        public void WhenElUsuarioCompreUnaMembresia()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se mostrara una pantalla indicando los beneficios exclusivos del que forma parte su cuenta ,monto cobrado y fecha de cargo a la tarjeta\.")]
        public void ThenSeMostraraUnaPantallaIndicandoLosBeneficiosExclusivosDelQueFormaParteSuCuentaMontoCobradoYFechaDeCargoALaTarjeta_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se mostrara una pantalla indicando que la tarjeta ha sido rechazada por algún motivo especifico\.")]
        public void ThenSeMostraraUnaPantallaIndicandoQueLaTarjetaHaSidoRechazadaPorAlgunMotivoEspecifico_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
