Feature: Feature1

A short summary of the feature

@tag1
Scenario: El usuario realiza el pago de una membresía con una tarjeta valida
	Given que el usuario se encuentra en la vista de “Planes en Chreana”
	When el usuario compre una membresia 
	Then se mostrara una pantalla indicando los beneficios exclusivos del que forma parte su cuenta ,monto cobrado y fecha de cargo a la tarjeta.
@tag1
Scenario: El usuario realiza el pago de una membresía con una tarjeta invalida
	Given que el usuario se encuentra en la vista de “Planes en Chreana”
	When el usuario compre una membresia 
	Then se mostrara una pantalla indicando que la tarjeta ha sido rechazada por algún motivo especifico.
