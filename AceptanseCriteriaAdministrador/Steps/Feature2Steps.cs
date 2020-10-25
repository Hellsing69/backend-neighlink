using System;
using TechTalk.SpecFlow;

namespace AceptanseCriteriaAdministrador.Steps
{
    [Binding]
    public class Feature2Steps
    {
        [Given(@"que el usuario se encuentra en la vista de “Mi plan en Chreana”")]
        public void GivenQueElUsuarioSeEncuentraEnLaVistaDeMiPlanEnChreana()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"el usuario cancele su membresia")]
        public void WhenElUsuarioCanceleSuMembresia()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se mostrara una pantalla indicando que podrá disfrutar de sus beneficios hasta la próxima fecha de recargo\.")]
        public void ThenSeMostraraUnaPantallaIndicandoQuePodraDisfrutarDeSusBeneficiosHastaLaProximaFechaDeRecargo_()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"se mostrara una pantalla indicando que se realizara el recargo de este ultimo mes\.")]
        public void ThenSeMostraraUnaPantallaIndicandoQueSeRealizaraElRecargoDeEsteUltimoMes_()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
