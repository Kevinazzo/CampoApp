
DROP PROCEDURE IF EXISTS cargartype;

DELIMITER $$
CREATE procedure cargartype(
in tipoo enum('restaurante','senderismo','camping')
 )
Begin


select * from site where tag =tipoo;

END$$

call cargartype('restaurante');