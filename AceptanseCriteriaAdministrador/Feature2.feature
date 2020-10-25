Feature: Feature2

A short summary of the feature

@tag1
Scenario: El usuario realiza la cancelación de su membresia antes de la fecha de recargo
	Given que el usuario se encuentra en la vista de “Mi plan en Chreana”
	When el usuario cancele su membresia 
	Then se mostrara una pantalla indicando que podrá disfrutar de sus beneficios hasta la próxima fecha de recargo.

	@tag1
Scenario: El usuario realiza la cancelación de su membresia el mismo dia de recargo
	Given que el usuario se encuentra en la vista de “Mi plan en Chreana”
	When el usuario cancele su membresia 
	Then se mostrara una pantalla indicando que se realizara el recargo de este ultimo mes.
