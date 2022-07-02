# Azure Virtual Machine

## Objetivo
Crear una máquina virtual usando el servicio de Azure Virtual Machine

### Creación de la VM
1. En el portal de azure (portal.azure.com) buscar "Virtual Machine"
2. Clic en "Crear" para crear el recurso 
3. Introducir los detalles del proyecto
- Grupo de recursos
- Nombre del máquina virtual
- Centro de datos a utilizar (region)
- Opciones de disponibilidad (backup/redundancia)
- Imagen (SO a instalar) 
- Tamaño (características de la VM)
- Usuario y Contraseña de la VM
- Puerto de entrada: RPD  (para comunicarse con la computadora) 
- Discos y Redes (se puede dejar con el default)    

<img src="images/Captura1.PNG" alt="c1" width="400"/> 


### Conexión remota con la VM
1. Ir al recurso de la VM en el portal de Azure
2. En Conectar / RPD/ Descargar archivo RDP   

<img src="images/Captura3.PNG" alt="c3" width="400"/> 

3. Descargar y abrir el archivo en la computadora local 
4. Aceptar y la conexión
5. Introducir usuario y contraseña de la VM
6. Aceptar la conexión a escritorio remoto 
7. Usar la computadora virtual    

<img src="images/Captura8.PNG" alt="c8" width="400"/>     


### Borrado de la VM
1. Dentro del recurso
2. Detener el recurso y dar en Eliminar
3. Ir al grupo de recursos 
4. Eliminar los recursos adicionales uno por uno
<img src="images/Captura9.PNG" alt="c9" width="400"/>   




