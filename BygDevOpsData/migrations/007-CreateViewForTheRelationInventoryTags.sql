CREATE VIEW vista_inventory_tags AS 
SELECT t1.id AS inventory_id,
t1.details AS inventory_details,
t1.quantity AS inventory_quantity,
t1.imageurl AS inventory_image,
t1.is_deleted AS inventory_is_deleted,
t3.id AS tags_id,
t3.details AS tags_details,
t3.color AS tags_color,
t3.iconos AS tags_icons,
t3.is_deleted AS tags_is_deleted
  
 FROM inventory AS t1
INNER JOIN inventory_tags AS t2 ON t1.id = t2.inventario_id
INNER JOIN tags AS t3 ON t2.tags_id =  t3.id;