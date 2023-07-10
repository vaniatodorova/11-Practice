CREATE TABLE `sys`.`cities` (
  `city_id`INT(11) NOT NULL AUTO_INCREMENT, 
  `name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`city_id`),
  UNIQUE INDEX `city_id_UNIQUE` (`city_id` ASC));

CREATE TABLE `sys`.`customers` (
  `customer_id` INT(11) NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  `birthday` DATE NOT NULL,
  `city_id` INT(11) NOT NULL,
  PRIMARY KEY (`customer_id`),
  UNIQUE INDEX `customer_id_UNIQUE` (`customer_id` ASC),
  INDEX `city_id_idx` (`city_id` ASC),
  CONSTRAINT `city_id`
    FOREIGN KEY (`city_id`)
    REFERENCES `sys`.`cities` (`city_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
CREATE TABLE `sys`.`item_types` (
  `item_type_id` INT(11) NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`item_type_id`),
  UNIQUE INDEX `item_type_id_UNIQUE` (`item_type_id` ASC));
CREATE TABLE `sys`.`items` (
  `item_id` INT(11) NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(5) NOT NULL,
  `item_type_id` INT(11) NOT NULL,
  PRIMARY KEY (`item_id`),
  UNIQUE INDEX `item_id_UNIQUE` (`item_id` ASC),
  INDEX `item_type_id_idx` (`item_type_id` ASC),
  CONSTRAINT `item_type_id`
    FOREIGN KEY (`item_type_id`)
    REFERENCES `sys`.`item_types` (`item_type_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
CREATE TABLE `sys`.`orders` (
  `order_id` INT(11) NOT NULL AUTO_INCREMENT,
  `customer_id` INT(11) NOT NULL,
  PRIMARY KEY (`order_id`),
  UNIQUE INDEX `order_id_UNIQUE` (`order_id` ASC),
  INDEX `customer_id_idx` (`customer_id` ASC),
  CONSTRAINT `customer_id`
    FOREIGN KEY (`customer_id`)
    REFERENCES `sys`.`customers` (`customer_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
CREATE TABLE `sys`.`order_items` (
  `order_id` INT(11) NOT NULL,
  `item_id` INT(11) NOT NULL,
  PRIMARY KEY (`order_id`, `item_id`),
  INDEX `item_id_idx` (`item_id` ASC),
  CONSTRAINT `order_id`
    FOREIGN KEY (`order_id`)
    REFERENCES `sys`.`orders` (`order_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `item_id`
    FOREIGN KEY (`item_id`)
    REFERENCES `sys`.`items` (`item_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);