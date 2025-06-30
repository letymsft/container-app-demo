# Demo: Copilot Agents para el Desarrollo de Soluciones

Este repositorio presenta una demostración del uso de **Copilot Agents** como asistentes inteligentes para facilitar y optimizar el desarrollo de soluciones. El objetivo es mostrar cómo los agentes pueden integrarse para automatizar tareas, generar código, proponer diseños de arquitectura y asistir en procesos de decisión técnica.

## 🚀 Objetivos

- Demostrar el potencial de Copilot Agents en escenarios de desarrollo reales.
- Automatizar flujos comunes durante la implementación de soluciones.
- Proveer un punto de partida para extender la funcionalidad de los agentes en entornos empresariales.

## 📦 Problema

Como **Líder de Desarrollo** involucrado en múltiples proyectos, me enfrento diariamente a diversas tareas que van desde la revisión de código hasta la participación en sesiones técnicas. Para optimizar mi tiempo y aumentar la calidad de mis entregables, necesito apoyo en tareas como la mejora de código existente y la implementación de nuevos módulos. Esta demo muestra cómo **Copilot Agents** pueden asistir en estos retos diarios.

## 🧩 Solución Propuesta

Como parte del enfoque de observabilidad en nuestra solución, se integrará el monitoreo mediante **Application Insights** y **Log Analytics** dentro de una solución ya existente. Esta implementación garantiza una trazabilidad uniforme, métricas centralizadas y la capacidad de diagnosticar problemas en tiempo real. Esta práctica se aplica de forma transversal a todos los desarrollos, asegurando la alineación con las políticas de monitoreo empresarial.

## ✅ Prerrequisitos

Antes de comenzar, asegúrate de contar con lo siguiente:

- Una cuenta activa en [GitHub](https://github.com).
- Un proyecto definido que desees ampliar o automatizar mediante Copilot Agents.
- Un repositorio ya creado en GitHub que contenga o esté relacionado con ese proyecto.

> Nota: Si aún no tienes un repositorio, puedes crearlo desde tu cuenta de GitHub haciendo clic en “New repository” y siguiendo los pasos del asistente.

## 🧪 Guía de Uso

Sigue estos pasos para comenzar a trabajar con Copilot Agents en un escenario real:

1. **Crear un nuevo proyecto**  
   Inicia un nuevo proyecto desde tu herramienta o repositorio favorito. En este ejemplo, nómbralo:  
   **`Monitoreo Aplicativo`**

2. **Generar una nueva tarea**  
   Dentro del proyecto, crea una tarea específica para abordar la integración del monitoreo. Usa el siguiente nombre:  
   **`Implementación de monitoreo en el módulo`**

3. **Asignar la tarea a Copilot**  
   Para que el agente pueda ayudarte, asigna la tarea escribiendo en el cuerpo o descripción:  
   **`@copilot`**  
   Esto permite que el agente comience a sugerir soluciones, líneas de código o documentación relevante en contexto.
   
![image](https://github.com/user-attachments/assets/835cd6b7-abb7-45a2-b60c-49792051319f)

> 💡 Sugerencia: Si usas GitHub Projects o Issues, puedes crear esta tarea como un *issue* y mencionarlo con `@copilot` directamente en los comentarios para activar la colaboración.
> 

Una vez que inicie las actividades Copilot en modo Agente, se creará una notificación y también se podrá ver el estado de la ejecución por medio del botón View Session.

![image](https://github.com/user-attachments/assets/08712f83-a60a-45e2-b484-0305400c721b)

En la sesión del agente podrás encontrar la rama de trabajo creada por Copilot, el tiempo de ejecución, las tareas que se están desarrollando, así como el detalle de los cambios para cada archivo dentro de la solucíón.
Rama de trabajo:
![image](https://github.com/user-attachments/assets/96941acc-5d26-4410-be4f-3ee1961dec13)

Pasos de la ejecución de tareas del agente:
![image](https://github.com/user-attachments/assets/1c730e9b-cf31-4575-ad88-810ddf3e6e7c)

Una vez que haya terminado la ejecución, se notifica en la ventana y se muestra el pull request

![image](https://github.com/user-attachments/assets/0e082b76-da62-492d-81d7-f3d39b64b616)

En el pull request podrás ver el detalle de los cambios, así como la solicitud para realizar el merge en la rama principal de la solución:
![image](https://github.com/user-attachments/assets/30d1ee00-11ee-4f07-9952-06d8f7b3ec97)

En la sección de Cambios de Archivo (Files changed) del Pull Request, podrás ver un comparativo de la versión original vs la versión actualizada ejecutada por el agente de Copilot para que puedas realizar una revisión del trabajo realizado. Por medio de indicadores de color (Rojo y Verde se muestra el detalle de lo que se eliminará y lo que agregará dentro de la solución. Por las instrucciones que se le dieron al agente, se integra las instrucciones de Logger dentro del código de la clase para solventar la solicitud realizada.
![image](https://github.com/user-attachments/assets/74412486-d372-4f7a-ad55-46fc87857cb1)

Ahora, siéntente con la libertad de revisar, cambiar, aceptar o rechazar los cambios realizados en tu solución. Ya parte del trabajo está hecho y tu puedes avanzar con otras tareas.

## **¡Copilot Agent está aquí para ayudarte!**





