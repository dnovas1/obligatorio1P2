# obligatorio1P2
Primer obligatorio Programacion2

Se nos ha asignado el desarrollo de una plataforma de venta de artículos que operará en todo el país.
La empresa anuncia que tendrá un enorme catálogo de productos a la venta, y promete muchos beneficios a los
usuarios que se registren en la aplicación.
En la plataforma conviven 2 tipos de usuarios, los Clientes y los Administradores.
De todos los usuarios se conoce id (autonumérico), nombre, apellido, email y contraseña. Pero de los clientes se
conoce además el saldo disponible en su billetera electrónica.
Posee un catálogo de artículos y de cada uno se conoce un id(autonumérico), el nombre, la categoría, y el precio
de venta.
El modelo de negocio de esta empresa consiste en realizar publicaciones de los artículos que pone a la venta. No
los vende de forma individual, sino que se venden a través de estas publicaciones.
De cada publicación se conoce un id (autonumérico), un nombre, el estado de la publicación que puede ser
ABIERTA, CERRADA, CANCELADA, la fecha de publicación, y la lista de artículos que se venden en ella.
Además, posee el cliente que realizó la compra, el usuario que finalizó la compra y la fecha en que finalizó, estos
datos permanecen vacíos mientras se encuentre en estado ABIERTA.
Existen dos tipos de publicaciones, las ventas y las subastas.
De las ventas se sabe si está en “oferta relámpago”, y de las subastas se conoce además una lista de ofertas que
son las que realizan los usuarios para “ganar” la subasta.
De cada oferta se conoce el id (autonumérico), usuario, el monto, y la fecha en que la realizó.
