'use strict';


/**
 * Parses a hexadecimal string to regular base 10
 * @param  {String} byte
 * @return {Number}
 */
export function parseHexToDecimal (byte: string) {
  return parseInt(byte, 16);
};


/**
 * Converts an OBD value to a percentage
 * @param  {String} byte
 * @return {Number}
 */
export function percentage (byte: string) {
  return parseHexToDecimal(byte) * (100 / 255);
};
