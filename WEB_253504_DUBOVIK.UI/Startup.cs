using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ProductApp
{
    public class Startup
    {
        // Метод для регистрации сервисов (DI)
        public void ConfigureServices(IServiceCollection services)
        {
            // Добавление MVC: поддержка контроллеров и представлений
            services.AddControllersWithViews();
        }

        // Метод для настройки конвейера обработки запросов (middleware)
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Включение режима отладки в процессе разработки
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // Страница обработки ошибок в продакшене
                app.UseExceptionHandler("/Home/Error");
                // Включение HSTS (HTTP Strict Transport Security)
                app.UseHsts();
            }

            // Принудительное использование HTTPS
            app.UseHttpsRedirection();
            // Включение поддержки статических файлов
            app.UseStaticFiles();

            // Включение маршрутизации
            app.UseRouting();

            // Включение авторизации (по умолчанию без дополнительной настройки)
            app.UseAuthorization();

            // Настройка конечных точек маршрутизации
            app.UseEndpoints(endpoints =>
            {
                // Стандартный маршрут для MVC
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
