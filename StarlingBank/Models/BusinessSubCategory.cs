using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StarlingBank.Models
{
    /// <summary>
    /// Enum BusinessSubCategory
    /// </summary>
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum BusinessSubCategory
    {
        /// <summary>
        /// Not provided
        /// </summary>
        NOT_PROVIDED,

        /// <summary>
        /// Art and craft supplies
        /// </summary>
        ART_AND_CRAFT_SUPPLIES,

        /// <summary>
        /// Art dealers and galleries
        /// </summary>
        ART_DEALERS_AND_GALLERIES,

        /// <summary>
        /// Camera and photographic supplies
        /// </summary>
        CAMERA_AND_PHOTOGRAPHIC_SUPPLIES,

        /// <summary>
        /// Digital art
        /// </summary>
        DIGITAL_ART,

        /// <summary>
        /// Memorabilia
        /// </summary>
        MEMORABILIA,

        /// <summary>
        /// Music store instruments and sheet music
        /// </summary>
        MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC,

        /// <summary>
        /// Sewing needlework and fabrics
        /// </summary>
        SEWING_NEEDLEWORK_AND_FABRICS,

        /// <summary>
        /// Stamp and coin
        /// </summary>
        STAMP_AND_COIN,

        /// <summary>
        /// Stationary printing and writing paper
        /// </summary>
        STATIONARY_PRINTING_AND_WRITING_PAPER,

        /// <summary>
        /// Vintage and collectibles
        /// </summary>
        VINTAGE_AND_COLLECTIBLES,

        /// <summary>
        /// Clothing
        /// </summary>
        CLOTHING,

        /// <summary>
        /// Furniture
        /// </summary>
        FURNITURE,

        /// <summary>
        /// Baby products other
        /// </summary>
        BABY_PRODUCTS_OTHER,

        /// <summary>
        /// Safety and health
        /// </summary>
        SAFETY_AND_HEALTH,

        /// <summary>
        /// Bath and body
        /// </summary>
        BATH_AND_BODY,

        /// <summary>
        /// Fragrances and perfumes
        /// </summary>
        FRAGRANCES_AND_PERFUMES,

        /// <summary>
        /// Makeup and cosmetics
        /// </summary>
        MAKEUP_AND_COSMETICS,

        /// <summary>
        /// Audio books
        /// </summary>
        AUDIO_BOOKS,

        /// <summary>
        /// Digital content
        /// </summary>
        DIGITAL_CONTENT,

        /// <summary>
        /// Educational and textbooks
        /// </summary>
        EDUCATIONAL_AND_TEXTBOOKS,

        /// <summary>
        /// Fiction and nonfiction
        /// </summary>
        FICTION_AND_NONFICTION,

        /// <summary>
        /// Magazines
        /// </summary>
        MAGAZINES,

        /// <summary>
        /// Books publishing and printing
        /// </summary>
        BOOKS_PUBLISHING_AND_PRINTING,

        /// <summary>
        /// Rare and used books
        /// </summary>
        RARE_AND_USED_BOOKS,

        /// <summary>
        /// Accounting
        /// </summary>
        ACCOUNTING,

        /// <summary>
        /// Advertising
        /// </summary>
        ADVERTISING,

        /// <summary>
        /// Agricultural
        /// </summary>
        AGRICULTURAL,

        /// <summary>
        /// Architectural engineering and surveying services
        /// </summary>
        ARCHITECTURAL_ENGINEERING_AND_SURVEYING_SERVICES,

        /// <summary>
        /// Chemicals and allied products
        /// </summary>
        CHEMICALS_AND_ALLIED_PRODUCTS,

        /// <summary>
        /// Commercial photography art and graphics
        /// </summary>
        COMMERCIAL_PHOTOGRAPHY_ART_AND_GRAPHICS,

        /// <summary>
        /// Construction
        /// </summary>
        CONSTRUCTION,

        /// <summary>
        /// Consulting services
        /// </summary>
        CONSULTING_SERVICES,

        /// <summary>
        /// Educational services
        /// </summary>
        EDUCATIONAL_SERVICES,

        /// <summary>
        /// Equipment rentals and leasing services
        /// </summary>
        EQUIPMENT_RENTALS_AND_LEASING_SERVICES,

        /// <summary>
        /// Equipment repair services
        /// </summary>
        EQUIPMENT_REPAIR_SERVICES,

        /// <summary>
        /// Hiring services
        /// </summary>
        HIRING_SERVICES,

        /// <summary>
        /// Industrial and manufacturing supplies
        /// </summary>
        INDUSTRIAL_AND_MANUFACTURING_SUPPLIES,

        /// <summary>
        /// Mailing lists
        /// </summary>
        MAILING_LISTS,

        /// <summary>
        /// Marketing
        /// </summary>
        MARKETING,

        /// <summary>
        /// Multilevel marketing
        /// </summary>
        MULTILEVEL_MARKETING,

        /// <summary>
        /// Office and commercial furniture
        /// </summary>
        OFFICE_AND_COMMERCIAL_FURNITURE,

        /// <summary>
        /// Office supplies and equipment
        /// </summary>
        OFFICE_SUPPLIES_AND_EQUIPMENT,

        /// <summary>
        /// Publishing and printing
        /// </summary>
        PUBLISHING_AND_PRINTING,

        /// <summary>
        /// Quick copy and reproduction services
        /// </summary>
        QUICK_COPY_AND_REPRODUCTION_SERVICES,

        /// <summary>
        /// Shipping and packing
        /// </summary>
        SHIPPING_AND_PACKING,

        /// <summary>
        /// Stenographic and secretarial support services
        /// </summary>
        STENOGRAPHIC_AND_SECRETARIAL_SUPPORT_SERVICES,

        /// <summary>
        /// Wholesale
        /// </summary>
        WHOLESALE,

        /// <summary>
        /// Childrens clothing
        /// </summary>
        CHILDRENS_CLOTHING,

        /// <summary>
        /// Mens clothing
        /// </summary>
        MENS_CLOTHING,

        /// <summary>
        /// Womens clothing
        /// </summary>
        WOMENS_CLOTHING,

        /// <summary>
        /// Shoes
        /// </summary>
        SHOES,

        /// <summary>
        /// Military and civil service uniforms
        /// </summary>
        MILITARY_AND_CIVIL_SERVICE_UNIFORMS,

        /// <summary>
        /// Accessories
        /// </summary>
        ACCESSORIES,

        /// <summary>
        /// Retail fine jewelry and watches
        /// </summary>
        RETAIL_FINE_JEWELRY_AND_WATCHES,

        /// <summary>
        /// Wholesale precious stones and metals
        /// </summary>
        WHOLESALE_PRECIOUS_STONES_AND_METALS,

        /// <summary>
        /// Fashion jewellery
        /// </summary>
        FASHION_JEWELLERY,

        /// <summary>
        /// Computer and data processing services
        /// </summary>
        COMPUTER_AND_DATA_PROCESSING_SERVICES,

        /// <summary>
        /// Desktops laptops and notebooks
        /// </summary>
        DESKTOPS_LAPTOPS_AND_NOTEBOOKS,

        /// <summary>
        /// Computer digital content
        /// </summary>
        COMPUTER_DIGITAL_CONTENT,

        /// <summary>
        /// Ecommerce services
        /// </summary>
        ECOMMERCE_SERVICES,

        /// <summary>
        /// Maintenance and repair services
        /// </summary>
        MAINTENANCE_AND_REPAIR_SERVICES,

        /// <summary>
        /// Monitors and projectors
        /// </summary>
        MONITORS_AND_PROJECTORS,

        /// <summary>
        /// Networking
        /// </summary>
        NETWORKING,

        /// <summary>
        /// Online gaming
        /// </summary>
        ONLINE_GAMING,

        /// <summary>
        /// Parts and accessories
        /// </summary>
        PARTS_AND_ACCESSORIES,

        /// <summary>
        /// Peripherals
        /// </summary>
        PERIPHERALS,

        /// <summary>
        /// Software
        /// </summary>
        SOFTWARE,

        /// <summary>
        /// Training services
        /// </summary>
        TRAINING_SERVICES,

        /// <summary>
        /// Web hosting and design
        /// </summary>
        WEB_HOSTING_AND_DESIGN,

        /// <summary>
        /// Business and secretarial schools
        /// </summary>
        BUSINESS_AND_SECRETARIAL_SCHOOLS,

        /// <summary>
        /// Child daycare services
        /// </summary>
        CHILD_DAYCARE_SERVICES,

        /// <summary>
        /// Dance halls studios and schools
        /// </summary>
        DANCE_HALLS_STUDIOS_AND_SCHOOLS,

        /// <summary>
        /// Vocational and trade schools
        /// </summary>
        VOCATIONAL_AND_TRADE_SCHOOLS,

        /// <summary>
        /// Cameras camcorders and equipment
        /// </summary>
        CAMERAS_CAMCORDERS_AND_EQUIPMENT,

        /// <summary>
        /// Cell phones pdas and pagers
        /// </summary>
        CELL_PHONES_PDAS_AND_PAGERS,

        /// <summary>
        /// General electronic accessories
        /// </summary>
        GENERAL_ELECTRONIC_ACCESSORIES,

        /// <summary>
        /// Home audio
        /// </summary>
        HOME_AUDIO,

        /// <summary>
        /// Home electronics
        /// </summary>
        HOME_ELECTRONICS,

        /// <summary>
        /// Security and surveillance
        /// </summary>
        SECURITY_AND_SURVEILLANCE,

        /// <summary>
        /// Telecommunication equipment and sales
        /// </summary>
        TELECOMMUNICATION_EQUIPMENT_AND_SALES,

        /// <summary>
        /// Telecommunication services
        /// </summary>
        TELECOMMUNICATION_SERVICES,

        /// <summary>
        /// Telephone cards
        /// </summary>
        TELEPHONE_CARDS,

        /// <summary>
        /// Entertainment memorabilia
        /// </summary>
        ENTERTAINMENT_MEMORABILIA,

        /// <summary>
        /// Movie tickets
        /// </summary>
        MOVIE_TICKETS,

        /// <summary>
        /// Movies DVDS videotapes
        /// </summary>
        MOVIES_DVDS_VIDEOTAPES,

        /// <summary>
        /// Music CDS cassettes and albums
        /// </summary>
        MUSIC_CDS_CASSETTES_AND_ALBUMS,

        /// <summary>
        /// Cable satellite and other pay tv and radio
        /// </summary>
        CABLE_SATELLITE_AND_OTHER_PAY_TV_AND_RADIO,

        /// <summary>
        /// Concert tickets
        /// </summary>
        CONCERT_TICKETS,

        /// <summary>
        /// Theater tickets
        /// </summary>
        THEATER_TICKETS,

        /// <summary>
        /// Toys and games
        /// </summary>
        TOYS_AND_GAMES,

        /// <summary>
        /// Entertainment digital content
        /// </summary>
        ENTERTAINMENT_DIGITAL_CONTENT,

        /// <summary>
        /// Entertainers
        /// </summary>
        ENTERTAINERS,

        /// <summary>
        /// Online games
        /// </summary>
        ONLINE_GAMES,

        /// <summary>
        /// Video games and systems
        /// </summary>
        VIDEO_GAMES_AND_SYSTEMS,

        /// <summary>
        /// Financial accounting
        /// </summary>
        FINANCIAL_ACCOUNTING,

        /// <summary>
        /// Debt counseling service
        /// </summary>
        DEBT_COUNSELING_SERVICE,

        /// <summary>
        /// Financial and investment advice
        /// </summary>
        FINANCIAL_AND_INVESTMENT_ADVICE,

        /// <summary>
        /// Real estate agent
        /// </summary>
        REAL_ESTATE_AGENT,

        /// <summary>
        /// Rental property management
        /// </summary>
        RENTAL_PROPERTY_MANAGEMENT,

        /// <summary>
        /// Alcoholic beverages
        /// </summary>
        ALCOHOLIC_BEVERAGES,

        /// <summary>
        /// Catering services
        /// </summary>
        CATERING_SERVICES,

        /// <summary>
        /// Coffee and tea
        /// </summary>
        COFFEE_AND_TEA,

        /// <summary>
        /// Gourmet foods
        /// </summary>
        GOURMET_FOODS,

        /// <summary>
        /// Specialty and miscellaneous food stores
        /// </summary>
        SPECIALTY_AND_MISCELLANEOUS_FOOD_STORES,

        /// <summary>
        /// Restaurant
        /// </summary>
        RESTAURANT,

        /// <summary>
        /// Tobacco
        /// </summary>
        TOBACCO,

        /// <summary>
        /// Vitamins and supplements
        /// </summary>
        VITAMINS_AND_SUPPLEMENTS,

        /// <summary>
        /// Florist
        /// </summary>
        FLORIST,

        /// <summary>
        /// Gift card novelty and souvenir shops
        /// </summary>
        GIFT_CARD_NOVELTY_AND_SOUVENIR_SHOPS,

        /// <summary>
        /// Gifts gourmet foods
        /// </summary>
        GIFTS_GOURMET_FOODS,

        /// <summary>
        /// Nursery plants and flowers
        /// </summary>
        NURSERY_PLANTS_AND_FLOWERS,

        /// <summary>
        /// Party supplies
        /// </summary>
        PARTY_SUPPLIES,

        /// <summary>
        /// Dental care
        /// </summary>
        DENTAL_CARE,

        /// <summary>
        /// Medical care
        /// </summary>
        MEDICAL_CARE,

        /// <summary>
        /// Medical equipment and supplies
        /// </summary>
        MEDICAL_EQUIPMENT_AND_SUPPLIES,

        /// <summary>
        /// Vision care
        /// </summary>
        VISION_CARE,

        /// <summary>
        /// Health vitamins and supplements
        /// </summary>
        HEALTH_VITAMINS_AND_SUPPLEMENTS,

        /// <summary>
        /// Appliances
        /// </summary>
        APPLIANCES,

        /// <summary>
        /// Home art dealers and galleries
        /// </summary>
        HOME_ART_DEALERS_AND_GALLERIES,

        /// <summary>
        /// Bed and bath
        /// </summary>
        BED_AND_BATH,

        /// <summary>
        /// Construction material
        /// </summary>
        CONSTRUCTION_MATERIAL,

        /// <summary>
        /// Drapery window covering and upholstery
        /// </summary>
        DRAPERY_WINDOW_COVERING_AND_UPHOLSTERY,

        /// <summary>
        /// Exterminating and disinfecting services
        /// </summary>
        EXTERMINATING_AND_DISINFECTING_SERVICES,

        /// <summary>
        /// Fireplace and fireplace screens
        /// </summary>
        FIREPLACE_AND_FIREPLACE_SCREENS,

        /// <summary>
        /// Home furniture
        /// </summary>
        HOME_FURNITURE,

        /// <summary>
        /// Garden supplies
        /// </summary>
        GARDEN_SUPPLIES,

        /// <summary>
        /// Glass paint and wallpaper
        /// </summary>
        GLASS_PAINT_AND_WALLPAPER,

        /// <summary>
        /// Hardware and tools
        /// </summary>
        HARDWARE_AND_TOOLS,

        /// <summary>
        /// Home decor
        /// </summary>
        HOME_DECOR,

        /// <summary>
        /// Housewares
        /// </summary>
        HOUSEWARES,

        /// <summary>
        /// Kitchenware
        /// </summary>
        KITCHENWARE,

        /// <summary>
        /// Landscaping
        /// </summary>
        LANDSCAPING,

        /// <summary>
        /// Rugs and carpets
        /// </summary>
        RUGS_AND_CARPETS,

        /// <summary>
        /// Security and surveillance equipment
        /// </summary>
        SECURITY_AND_SURVEILLANCE_EQUIPMENT,

        /// <summary>
        /// Swimming pools and spas
        /// </summary>
        SWIMMING_POOLS_AND_SPAS,

        /// <summary>
        /// Charity
        /// </summary>
        CHARITY,

        /// <summary>
        /// Political
        /// </summary>
        POLITICAL,

        /// <summary>
        /// Religious
        /// </summary>
        RELIGIOUS,

        /// <summary>
        /// Other
        /// </summary>
        OTHER,

        /// <summary>
        /// Personal
        /// </summary>
        PERSONAL,

        /// <summary>
        /// Educational
        /// </summary>
        EDUCATIONAL,

        /// <summary>
        /// Medication and supplements
        /// </summary>
        MEDICATION_AND_SUPPLEMENTS,

        /// <summary>
        /// Pet shops pet food and supplies
        /// </summary>
        PET_SHOPS_PET_FOOD_AND_SUPPLIES,

        /// <summary>
        /// Specialty or rare pets
        /// </summary>
        SPECIALTY_OR_RARE_PETS,

        /// <summary>
        /// Veterinary services
        /// </summary>
        VETERINARY_SERVICES,

        /// <summary>
        /// Membership services
        /// </summary>
        MEMBERSHIP_SERVICES,

        /// <summary>
        /// Merchandise
        /// </summary>
        MERCHANDISE,

        /// <summary>
        /// Services not elsewhere classified
        /// </summary>
        SERVICES_NOT_ELSEWHERE_CLASSIFIED,

        /// <summary>
        /// Retail chemicals and allied products
        /// </summary>
        RETAIL_CHEMICALS_AND_ALLIED_PRODUCTS,

        /// <summary>
        /// Department store
        /// </summary>
        DEPARTMENT_STORE,

        /// <summary>
        /// Discount store
        /// </summary>
        DISCOUNT_STORE,

        /// <summary>
        /// Durable goods
        /// </summary>
        DURABLE_GOODS,

        /// <summary>
        /// Nondurable goods
        /// </summary>
        NONDURABLE_GOODS,

        /// <summary>
        /// Used and secondhand store
        /// </summary>
        USED_AND_SECONDHAND_STORE,

        /// <summary>
        /// Variety store
        /// </summary>
        VARIETY_STORE,

        /// <summary>
        /// Services advertising
        /// </summary>
        SERVICES_ADVERTISING,

        /// <summary>
        /// Shopping services and buying clubs
        /// </summary>
        SHOPPING_SERVICES_AND_BUYING_CLUBS,

        /// <summary>
        /// Career services
        /// </summary>
        CAREER_SERVICES,

        /// <summary>
        /// Carpentry
        /// </summary>
        CARPENTRY,

        /// <summary>
        /// Child care services
        /// </summary>
        CHILD_CARE_SERVICES,

        /// <summary>
        /// Cleaning and maintenance
        /// </summary>
        CLEANING_AND_MAINTENANCE,

        /// <summary>
        /// Commercial photography
        /// </summary>
        COMMERCIAL_PHOTOGRAPHY,

        /// <summary>
        /// Services computer and data processing services
        /// </summary>
        SERVICES_COMPUTER_AND_DATA_PROCESSING_SERVICES,

        /// <summary>
        /// Computer network services
        /// </summary>
        COMPUTER_NETWORK_SERVICES,

        /// <summary>
        /// Services consulting services
        /// </summary>
        SERVICES_CONSULTING_SERVICES,

        /// <summary>
        /// Counseling services
        /// </summary>
        COUNSELING_SERVICES,

        /// <summary>
        /// Courier services
        /// </summary>
        COURIER_SERVICES,

        /// <summary>
        /// Services dental care
        /// </summary>
        SERVICES_DENTAL_CARE,

        /// <summary>
        /// Services ecommerce services
        /// </summary>
        SERVICES_ECOMMERCE_SERVICES,

        /// <summary>
        /// Electrical and small appliance repair
        /// </summary>
        ELECTRICAL_AND_SMALL_APPLIANCE_REPAIR,

        /// <summary>
        /// Entertainment
        /// </summary>
        ENTERTAINMENT,

        /// <summary>
        /// Equipment rental and leasing services
        /// </summary>
        EQUIPMENT_RENTAL_AND_LEASING_SERVICES,

        /// <summary>
        /// Event and wedding planning
        /// </summary>
        EVENT_AND_WEDDING_PLANNING,

        /// <summary>
        /// General contractors
        /// </summary>
        GENERAL_CONTRACTORS,

        /// <summary>
        /// Graphic and commercial design
        /// </summary>
        GRAPHIC_AND_COMMERCIAL_DESIGN,

        /// <summary>
        /// Health and beauty spas
        /// </summary>
        HEALTH_AND_BEAUTY_SPAS,

        /// <summary>
        /// Ids licenses and passports
        /// </summary>
        IDS_LICENSES_AND_PASSPORTS,

        /// <summary>
        /// Importing and exporting
        /// </summary>
        IMPORTING_AND_EXPORTING,

        /// <summary>
        /// Information retrieval services
        /// </summary>
        INFORMATION_RETRIEVAL_SERVICES,

        /// <summary>
        /// Landscaping and horticultural
        /// </summary>
        LANDSCAPING_AND_HORTICULTURAL,

        /// <summary>
        /// Legal services and attorneys
        /// </summary>
        LEGAL_SERVICES_AND_ATTORNEYS,

        /// <summary>
        /// Local delivery service
        /// </summary>
        LOCAL_DELIVERY_SERVICE,

        /// <summary>
        /// Services medical care
        /// </summary>
        SERVICES_MEDICAL_CARE,

        /// <summary>
        /// Membership clubs and organizations
        /// </summary>
        MEMBERSHIP_CLUBS_AND_ORGANIZATIONS,

        /// <summary>
        /// Services misc publishing and printing
        /// </summary>
        SERVICES_MISC_PUBLISHING_AND_PRINTING,

        /// <summary>
        /// Moving and storage
        /// </summary>
        MOVING_AND_STORAGE,

        /// <summary>
        /// Photofinishing
        /// </summary>
        PHOTOFINISHING,

        /// <summary>
        /// Photographic studios portraits
        /// </summary>
        PHOTOGRAPHIC_STUDIOS_PORTRAITS,

        /// <summary>
        /// Protective and security services
        /// </summary>
        PROTECTIVE_AND_SECURITY_SERVICES,

        /// <summary>
        /// Services quick copy and reproduction services
        /// </summary>
        SERVICES_QUICK_COPY_AND_REPRODUCTION_SERVICES,

        /// <summary>
        /// Radio television and stereo repair
        /// </summary>
        RADIO_TELEVISION_AND_STEREO_REPAIR,

        /// <summary>
        /// Real estate agent 1
        /// </summary>
        REAL_ESTATE_AGENT_1,

        /// <summary>
        /// Services rental property management
        /// </summary>
        SERVICES_RENTAL_PROPERTY_MANAGEMENT,

        /// <summary>
        /// Reupholstery and furniture repair
        /// </summary>
        REUPHOLSTERY_AND_FURNITURE_REPAIR,

        /// <summary>
        /// Services services not elsewhere classified
        /// </summary>
        SERVICES_SERVICES_NOT_ELSEWHERE_CLASSIFIED,

        /// <summary>
        /// Services shipping and packing
        /// </summary>
        SERVICES_SHIPPING_AND_PACKING,

        /// <summary>
        /// Swimming pool services
        /// </summary>
        SWIMMING_POOL_SERVICES,

        /// <summary>
        /// Tailors and alterations
        /// </summary>
        TAILORS_AND_ALTERATIONS,

        /// <summary>
        /// Telecommunication service
        /// </summary>
        TELECOMMUNICATION_SERVICE,

        /// <summary>
        /// Utilities
        /// </summary>
        UTILITIES,

        /// <summary>
        /// Services vision care
        /// </summary>
        SERVICES_VISION_CARE,

        /// <summary>
        /// Watch clock and jewelry repair
        /// </summary>
        WATCH_CLOCK_AND_JEWELRY_REPAIR,

        /// <summary>
        /// Athletic shoes
        /// </summary>
        ATHLETIC_SHOES,

        /// <summary>
        /// Bicycle shop service and repair
        /// </summary>
        BICYCLE_SHOP_SERVICE_AND_REPAIR,

        /// <summary>
        /// Boating sailing and accessories
        /// </summary>
        BOATING_SAILING_AND_ACCESSORIES,

        /// <summary>
        /// Camping and outdoors
        /// </summary>
        CAMPING_AND_OUTDOORS,

        /// <summary>
        /// Sports dance halls studios and schools
        /// </summary>
        SPORTS_DANCE_HALLS_STUDIOS_AND_SCHOOLS,

        /// <summary>
        /// Exercise and fitness
        /// </summary>
        EXERCISE_AND_FITNESS,

        /// <summary>
        /// Fan gear and memorabilia
        /// </summary>
        FAN_GEAR_AND_MEMORABILIA,

        /// <summary>
        /// Hunting
        /// </summary>
        HUNTING,

        /// <summary>
        /// Martial arts weapons
        /// </summary>
        MARTIAL_ARTS_WEAPONS,

        /// <summary>
        /// Sport games and toys
        /// </summary>
        SPORT_GAMES_AND_TOYS,

        /// <summary>
        /// Sporting equipment
        /// </summary>
        SPORTING_EQUIPMENT,

        /// <summary>
        /// Sports swimming pools and spas
        /// </summary>
        SPORTS_SWIMMING_POOLS_AND_SPAS,

        /// <summary>
        /// Arts and crafts
        /// </summary>
        ARTS_AND_CRAFTS,

        /// <summary>
        /// Hobbies camera and photographic supplies
        /// </summary>
        HOBBIES_CAMERA_AND_PHOTOGRAPHIC_SUPPLIES,

        /// <summary>
        /// Hobby toy and game shops
        /// </summary>
        HOBBY_TOY_AND_GAME_SHOPS,

        /// <summary>
        /// Hobbies memorabilia
        /// </summary>
        HOBBIES_MEMORABILIA,

        /// <summary>
        /// Music store instruments and sheet musi c1
        /// </summary>
        MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC1,

        /// <summary>
        /// Hobbies stamp and coin
        /// </summary>
        HOBBIES_STAMP_AND_COIN,

        /// <summary>
        /// Hobbies stationary printing and writing paper
        /// </summary>
        HOBBIES_STATIONARY_PRINTING_AND_WRITING_PAPER,

        /// <summary>
        /// Hobbies vintage and collectibles
        /// </summary>
        HOBBIES_VINTAGE_AND_COLLECTIBLES,

        /// <summary>
        /// Hobbies video games and systems
        /// </summary>
        HOBBIES_VIDEO_GAMES_AND_SYSTEMS,

        /// <summary>
        /// Airline
        /// </summary>
        AIRLINE,

        /// <summary>
        /// Automatic rental
        /// </summary>
        AUTO_RENTAL,

        /// <summary>
        /// Bus line
        /// </summary>
        BUS_LINE,

        /// <summary>
        /// Cruises
        /// </summary>
        CRUISES,

        /// <summary>
        /// Lodging and accommodations
        /// </summary>
        LODGING_AND_ACCOMMODATIONS,

        /// <summary>
        /// Luggage and leather goods
        /// </summary>
        LUGGAGE_AND_LEATHER_GOODS,

        /// <summary>
        /// Recreational services
        /// </summary>
        RECREATIONAL_SERVICES,

        /// <summary>
        /// Sporting and recreation camps
        /// </summary>
        SPORTING_AND_RECREATION_CAMPS,

        /// <summary>
        /// Taxicabs and limousines
        /// </summary>
        TAXICABS_AND_LIMOUSINES,

        /// <summary>
        /// Timeshares
        /// </summary>
        TIMESHARES,

        /// <summary>
        /// Tours
        /// </summary>
        TOURS,

        /// <summary>
        /// Trailer parks or campgrounds
        /// </summary>
        TRAILER_PARKS_OR_CAMPGROUNDS,

        /// <summary>
        /// Transportation services other
        /// </summary>
        TRANSPORTATION_SERVICES_OTHER,

        /// <summary>
        /// Travel agency
        /// </summary>
        TRAVEL_AGENCY,

        /// <summary>
        /// New parts and supplies motor vehicle
        /// </summary>
        NEW_PARTS_AND_SUPPLIES_MOTOR_VEHICLE,

        /// <summary>
        /// Used parts motor vehicle
        /// </summary>
        USED_PARTS_MOTOR_VEHICLE,

        /// <summary>
        /// Audio and video
        /// </summary>
        AUDIO_AND_VIDEO,

        /// <summary>
        /// Automatic body repair and paint
        /// </summary>
        AUTO_BODY_REPAIR_AND_PAINT,

        /// <summary>
        /// Services automatic rental
        /// </summary>
        SERVICES_AUTO_RENTAL,

        /// <summary>
        /// Automatic service
        /// </summary>
        AUTO_SERVICE,

        /// <summary>
        /// Automotive tire supply and service
        /// </summary>
        AUTOMOTIVE_TIRE_SUPPLY_AND_SERVICE,

        /// <summary>
        /// Boat rental and leases
        /// </summary>
        BOAT_RENTAL_AND_LEASES,

        /// <summary>
        /// Car wash
        /// </summary>
        CAR_WASH,

        /// <summary>
        /// Motor home and recreational vehicle rental
        /// </summary>
        MOTOR_HOME_AND_RECREATIONAL_VEHICLE_RENTAL,

        /// <summary>
        /// Tools and equipment
        /// </summary>
        TOOLS_AND_EQUIPMENT,

        /// <summary>
        /// Towing service
        /// </summary>
        TOWING_SERVICE,

        /// <summary>
        /// Truck and utility trailer rental
        /// </summary>
        TRUCK_AND_UTILITY_TRAILER_RENTAL,

        /// <summary>
        /// Vehicle accessories
        /// </summary>
        VEHICLE_ACCESSORIES,

        /// <summary>
        /// Architect structural engineer or surveyor
        /// </summary>
        ARCHITECT_STRUCTURAL_ENGINEER_OR_SURVEYOR,

        /// <summary>
        /// Accountancy and bookkeeping
        /// </summary>
        ACCOUNTANCY_AND_BOOKKEEPING,

        /// <summary>
        /// Business services
        /// </summary>
        BUSINESS_SERVICES,

        /// <summary>
        /// Financial or investment advice
        /// </summary>
        FINANCIAL_OR_INVESTMENT_ADVICE,

        /// <summary>
        /// Mortgage brokers
        /// </summary>
        MORTGAGE_BROKERS,

        /// <summary>
        /// Software and it
        /// </summary>
        SOFTWARE_AND_IT,

        /// <summary>
        /// Website development
        /// </summary>
        WEBSITE_DEVELOPMENT,

        /// <summary>
        /// Management consultancy
        /// </summary>
        MANAGEMENT_CONSULTANCY,

        /// <summary>
        /// Project management
        /// </summary>
        PROJECT_MANAGEMENT,

        /// <summary>
        /// Marketing advertising and design
        /// </summary>
        MARKETING_ADVERTISING_AND_DESIGN,

        /// <summary>
        /// Graphic design and illustration
        /// </summary>
        GRAPHIC_DESIGN_AND_ILLUSTRATION,

        /// <summary>
        /// Interior design
        /// </summary>
        INTERIOR_DESIGN,

        /// <summary>
        /// Recruitment and hiring
        /// </summary>
        RECRUITMENT_AND_HIRING,

        /// <summary>
        /// Legal
        /// </summary>
        LEGAL,

        /// <summary>
        /// Photography
        /// </summary>
        PHOTOGRAPHY,

        /// <summary>
        /// Security
        /// </summary>
        SECURITY,

        /// <summary>
        /// Professional services other
        /// </summary>
        PROFESSIONAL_SERVICES_OTHER,

        /// <summary>
        /// Personal trainer
        /// </summary>
        PERSONAL_TRAINER,

        /// <summary>
        /// Sports coach
        /// </summary>
        SPORTS_COACH,

        /// <summary>
        /// Sports club
        /// </summary>
        SPORTS_CLUB,

        /// <summary>
        /// Sports and fitness venue
        /// </summary>
        SPORTS_AND_FITNESS_VENUE,

        /// <summary>
        /// Gym operator
        /// </summary>
        GYM_OPERATOR,

        /// <summary>
        /// Class instructor
        /// </summary>
        CLASS_INSTRUCTOR,

        /// <summary>
        /// Exercise and fitness other
        /// </summary>
        EXERCISE_AND_FITNESS_OTHER,

        /// <summary>
        /// Restaurant or cafe
        /// </summary>
        RESTAURANT_OR_CAFE,

        /// <summary>
        /// Takeaway
        /// </summary>
        TAKEAWAY,

        /// <summary>
        /// Street food or market stall
        /// </summary>
        STREET_FOOD_OR_MARKET_STALL,

        /// <summary>
        /// Retail
        /// </summary>
        RETAIL,

        /// <summary>
        /// Wholesaling
        /// </summary>
        WHOLESALING,

        /// <summary>
        /// Salons
        /// </summary>
        SALONS,

        /// <summary>
        /// At home services
        /// </summary>
        AT_HOME_SERVICES,

        /// <summary>
        /// Licensed retail
        /// </summary>
        LICENSED_RETAIL,

        /// <summary>
        /// Licensed food venue
        /// </summary>
        LICENSED_FOOD_VENUE,

        /// <summary>
        /// Retail bars and restaurants other
        /// </summary>
        RETAIL_BARS_AND_RESTAURANTS_OTHER,

        /// <summary>
        /// Digital content or games
        /// </summary>
        DIGITAL_CONTENT_OR_GAMES,

        /// <summary>
        /// Promotion and publishing
        /// </summary>
        PROMOTION_AND_PUBLISHING,

        /// <summary>
        /// Catering
        /// </summary>
        CATERING,

        /// <summary>
        /// Entertainers and DJS
        /// </summary>
        ENTERTAINERS_AND_DJS,

        /// <summary>
        /// Events and weddings
        /// </summary>
        EVENTS_AND_WEDDINGS,

        /// <summary>
        /// Events products
        /// </summary>
        EVENTS_PRODUCTS,

        /// <summary>
        /// Events staffing and services
        /// </summary>
        EVENTS_STAFFING_AND_SERVICES,

        /// <summary>
        /// Travel agent
        /// </summary>
        TRAVEL_AGENT,

        /// <summary>
        /// Tour guide
        /// </summary>
        TOUR_GUIDE,

        /// <summary>
        /// Lodging and accommodation
        /// </summary>
        LODGING_AND_ACCOMMODATION,

        /// <summary>
        /// Tv and radio
        /// </summary>
        TV_AND_RADIO,

        /// <summary>
        /// Musician or groups
        /// </summary>
        MUSICIAN_OR_GROUPS,

        /// <summary>
        /// Entertainment and travel other
        /// </summary>
        ENTERTAINMENT_AND_TRAVEL_OTHER,

        /// <summary>
        /// Doctor nurse or midwife
        /// </summary>
        DOCTOR_NURSE_OR_MIDWIFE,

        /// <summary>
        /// Pharmacy
        /// </summary>
        PHARMACY,

        /// <summary>
        /// Personal and social care
        /// </summary>
        PERSONAL_AND_SOCIAL_CARE,

        /// <summary>
        /// Physiotherapist
        /// </summary>
        PHYSIOTHERAPIST,

        /// <summary>
        /// Nutrition and diet
        /// </summary>
        NUTRITION_AND_DIET,

        /// <summary>
        /// Mental health and counselling
        /// </summary>
        MENTAL_HEALTH_AND_COUNSELLING,

        /// <summary>
        /// Medical equipment and suppliers
        /// </summary>
        MEDICAL_EQUIPMENT_AND_SUPPLIERS,

        /// <summary>
        /// Dental
        /// </summary>
        DENTAL,

        /// <summary>
        /// Optician
        /// </summary>
        OPTICIAN,

        /// <summary>
        /// Other medical therapy
        /// </summary>
        OTHER_MEDICAL_THERAPY,

        /// <summary>
        /// Chiropractor or osteopath
        /// </summary>
        CHIROPRACTOR_OR_OSTEOPATH,

        /// <summary>
        /// Podiatrist
        /// </summary>
        PODIATRIST,

        /// <summary>
        /// Complimentary and alternative medicine
        /// </summary>
        COMPLIMENTARY_AND_ALTERNATIVE_MEDICINE,

        /// <summary>
        /// Health and social care other
        /// </summary>
        HEALTH_AND_SOCIAL_CARE_OTHER,

        /// <summary>
        /// HGV or bus or coach driver
        /// </summary>
        HGV_OR_BUS_OR_COACH_DRIVER,

        /// <summary>
        /// Taxi or private hire driver
        /// </summary>
        TAXI_OR_PRIVATE_HIRE_DRIVER,

        /// <summary>
        /// Train driver
        /// </summary>
        TRAIN_DRIVER,

        /// <summary>
        /// Other professional driver
        /// </summary>
        OTHER_PROFESSIONAL_DRIVER,

        /// <summary>
        /// Home delivery and courier firms
        /// </summary>
        HOME_DELIVERY_AND_COURIER_FIRMS,

        /// <summary>
        /// Haulage firms
        /// </summary>
        HAULAGE_FIRMS,

        /// <summary>
        /// Taxi or private hire operator
        /// </summary>
        TAXI_OR_PRIVATE_HIRE_OPERATOR,

        /// <summary>
        /// Minibus or coach operator
        /// </summary>
        MINIBUS_OR_COACH_OPERATOR,

        /// <summary>
        /// Vehicle repair and maintenance
        /// </summary>
        VEHICLE_REPAIR_AND_MAINTENANCE,

        /// <summary>
        /// New cars or vehicle sales
        /// </summary>
        NEW_CARS_OR_VEHICLE_SALES,

        /// <summary>
        /// Vehicle rental
        /// </summary>
        VEHICLE_RENTAL,

        /// <summary>
        /// Bicycle shops
        /// </summary>
        BICYCLE_SHOPS,

        /// <summary>
        /// Used car or vehicle sales
        /// </summary>
        USED_CAR_OR_VEHICLE_SALES,

        /// <summary>
        /// Vehicle parts
        /// </summary>
        VEHICLE_PARTS,

        /// <summary>
        /// Car washing
        /// </summary>
        CAR_WASHING,

        /// <summary>
        /// Transport and vehicles other
        /// </summary>
        TRANSPORT_AND_VEHICLES_OTHER,

        /// <summary>
        /// Cleaning
        /// </summary>
        CLEANING,

        /// <summary>
        /// Decorating
        /// </summary>
        DECORATING,

        /// <summary>
        /// Electrician
        /// </summary>
        ELECTRICIAN,

        /// <summary>
        /// Plumber
        /// </summary>
        PLUMBER,

        /// <summary>
        /// Gas and heating
        /// </summary>
        GAS_AND_HEATING,

        /// <summary>
        /// Carpentry trade
        /// </summary>
        CARPENTRY_TRADE,

        /// <summary>
        /// Roofing
        /// </summary>
        ROOFING,

        /// <summary>
        /// Gardening and tree surgery
        /// </summary>
        GARDENING_AND_TREE_SURGERY,

        /// <summary>
        /// General contractor
        /// </summary>
        GENERAL_CONTRACTOR,

        /// <summary>
        /// Construction supplier
        /// </summary>
        CONSTRUCTION_SUPPLIER,

        /// <summary>
        /// Waste and recycling
        /// </summary>
        WASTE_AND_RECYCLING,

        /// <summary>
        /// Site and building management
        /// </summary>
        SITE_AND_BUILDING_MANAGEMENT,

        /// <summary>
        /// Construction trades and cleaning other
        /// </summary>
        CONSTRUCTION_TRADES_AND_CLEANING_OTHER,

        /// <summary>
        /// Property owner
        /// </summary>
        PROPERTY_OWNER,

        /// <summary>
        /// Property investor
        /// </summary>
        PROPERTY_INVESTOR,

        /// <summary>
        /// Property investment fund
        /// </summary>
        PROPERTY_INVESTMENT_FUND,

        /// <summary>
        /// Residents association
        /// </summary>
        RESIDENTS_ASSOCIATION,

        /// <summary>
        /// Leasehold or freehold
        /// </summary>
        LEASEHOLD_OR_FREEHOLD,

        /// <summary>
        /// Holiday or short term lets
        /// </summary>
        HOLIDAY_OR_SHORT_TERM_LETS,

        /// <summary>
        /// Property redevelopment
        /// </summary>
        PROPERTY_REDEVELOPMENT,

        /// <summary>
        /// Estate agent
        /// </summary>
        ESTATE_AGENT,

        /// <summary>
        /// Property management
        /// </summary>
        PROPERTY_MANAGEMENT,

        /// <summary>
        /// Storage
        /// </summary>
        STORAGE,

        /// <summary>
        /// Property other
        /// </summary>
        PROPERTY_OTHER,

        /// <summary>
        /// Personal tutor
        /// </summary>
        PERSONAL_TUTOR,

        /// <summary>
        /// Music teachers
        /// </summary>
        MUSIC_TEACHERS,

        /// <summary>
        /// Professional trainer
        /// </summary>
        PROFESSIONAL_TRAINER,

        /// <summary>
        /// Public speaking
        /// </summary>
        PUBLIC_SPEAKING,

        /// <summary>
        /// Nursery
        /// </summary>
        NURSERY,

        /// <summary>
        /// Childminder
        /// </summary>
        CHILDMINDER,

        /// <summary>
        /// Nanny or au pair
        /// </summary>
        NANNY_OR_AU_PAIR,

        /// <summary>
        /// Childrens activities
        /// </summary>
        CHILDRENS_ACTIVITIES,

        /// <summary>
        /// Student recruitment
        /// </summary>
        STUDENT_RECRUITMENT,

        /// <summary>
        /// Schools colleges and training
        /// </summary>
        SCHOOLS_COLLEGES_AND_TRAINING,

        /// <summary>
        /// Education and skills other
        /// </summary>
        EDUCATION_AND_SKILLS_OTHER,

        /// <summary>
        /// Animals
        /// </summary>
        ANIMALS,

        /// <summary>
        /// Arts culture and humanities
        /// </summary>
        ARTS_CULTURE_AND_HUMANITIES,

        /// <summary>
        /// Community development
        /// </summary>
        COMMUNITY_DEVELOPMENT,

        /// <summary>
        /// Education
        /// </summary>
        EDUCATION,

        /// <summary>
        /// Environment
        /// </summary>
        ENVIRONMENT,

        /// <summary>
        /// Health and disease
        /// </summary>
        HEALTH_AND_DISEASE,

        /// <summary>
        /// Human and civil rights
        /// </summary>
        HUMAN_AND_CIVIL_RIGHTS,

        /// <summary>
        /// Children youth and family
        /// </summary>
        CHILDREN_YOUTH_AND_FAMILY,

        /// <summary>
        /// Homelessness
        /// </summary>
        HOMELESSNESS,

        /// <summary>
        /// International
        /// </summary>
        INTERNATIONAL,

        /// <summary>
        /// Research and public policy
        /// </summary>
        RESEARCH_AND_PUBLIC_POLICY,

        /// <summary>
        /// Religion
        /// </summary>
        RELIGION,

        /// <summary>
        /// Non profit other
        /// </summary>
        NON_PROFIT_OTHER,

        /// <summary>
        /// Manufacturing
        /// </summary>
        MANUFACTURING,

        /// <summary>
        /// Industrial engineer
        /// </summary>
        INDUSTRIAL_ENGINEER,

        /// <summary>
        /// Food or drink production
        /// </summary>
        FOOD_OR_DRINK_PRODUCTION,

        /// <summary>
        /// Research and development
        /// </summary>
        RESEARCH_AND_DEVELOPMENT,

        /// <summary>
        /// Livestock farming
        /// </summary>
        LIVESTOCK_FARMING,

        /// <summary>
        /// Crop farming
        /// </summary>
        CROP_FARMING,

        /// <summary>
        /// Horticulture or plant nursery
        /// </summary>
        HORTICULTURE_OR_PLANT_NURSERY,

        /// <summary>
        /// Forestry
        /// </summary>
        FORESTRY,

        /// <summary>
        /// Veterinary
        /// </summary>
        VETERINARY,

        /// <summary>
        /// Supplier to agriculture or industry
        /// </summary>
        SUPPLIER_TO_AGRICULTURE_OR_INDUSTRY,

        /// <summary>
        /// Equestrian
        /// </summary>
        EQUESTRIAN,

        /// <summary>
        /// Animal care
        /// </summary>
        ANIMAL_CARE,

        /// <summary>
        /// Manufacturing random and agriculture other
        /// </summary>
        MANUFACTURING_RND_AND_AGRICULTURE_OTHER
    }

    /// <summary>
    /// Helper for the enum type BusinessSubCategory
    /// </summary>
    public static class BusinessSubCategoryHelper
    {
        //string values corresponding the enum elements
        /// <summary>
        /// String values
        /// </summary>
        private static readonly List<string> StringValues = new List<string>
        {
            "NOT_PROVIDED",
            "ART_AND_CRAFT_SUPPLIES",
            "ART_DEALERS_AND_GALLERIES",
            "CAMERA_AND_PHOTOGRAPHIC_SUPPLIES",
            "DIGITAL_ART",
            "MEMORABILIA",
            "MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC",
            "SEWING_NEEDLEWORK_AND_FABRICS",
            "STAMP_AND_COIN",
            "STATIONARY_PRINTING_AND_WRITING_PAPER",
            "VINTAGE_AND_COLLECTIBLES",
            "CLOTHING",
            "FURNITURE",
            "BABY_PRODUCTS_OTHER",
            "SAFETY_AND_HEALTH",
            "BATH_AND_BODY",
            "FRAGRANCES_AND_PERFUMES",
            "MAKEUP_AND_COSMETICS",
            "AUDIO_BOOKS",
            "DIGITAL_CONTENT",
            "EDUCATIONAL_AND_TEXTBOOKS",
            "FICTION_AND_NONFICTION",
            "MAGAZINES",
            "BOOKS_PUBLISHING_AND_PRINTING",
            "RARE_AND_USED_BOOKS",
            "ACCOUNTING",
            "ADVERTISING",
            "AGRICULTURAL",
            "ARCHITECTURAL_ENGINEERING_AND_SURVEYING_SERVICES",
            "CHEMICALS_AND_ALLIED_PRODUCTS",
            "COMMERCIAL_PHOTOGRAPHY_ART_AND_GRAPHICS",
            "CONSTRUCTION",
            "CONSULTING_SERVICES",
            "EDUCATIONAL_SERVICES",
            "EQUIPMENT_RENTALS_AND_LEASING_SERVICES",
            "EQUIPMENT_REPAIR_SERVICES",
            "HIRING_SERVICES",
            "INDUSTRIAL_AND_MANUFACTURING_SUPPLIES",
            "MAILING_LISTS",
            "MARKETING",
            "MULTILEVEL_MARKETING",
            "OFFICE_AND_COMMERCIAL_FURNITURE",
            "OFFICE_SUPPLIES_AND_EQUIPMENT",
            "PUBLISHING_AND_PRINTING",
            "QUICK_COPY_AND_REPRODUCTION_SERVICES",
            "SHIPPING_AND_PACKING",
            "STENOGRAPHIC_AND_SECRETARIAL_SUPPORT_SERVICES",
            "WHOLESALE",
            "CHILDRENS_CLOTHING",
            "MENS_CLOTHING",
            "WOMENS_CLOTHING",
            "SHOES",
            "MILITARY_AND_CIVIL_SERVICE_UNIFORMS",
            "ACCESSORIES",
            "RETAIL_FINE_JEWELRY_AND_WATCHES",
            "WHOLESALE_PRECIOUS_STONES_AND_METALS",
            "FASHION_JEWELLERY",
            "COMPUTER_AND_DATA_PROCESSING_SERVICES",
            "DESKTOPS_LAPTOPS_AND_NOTEBOOKS",
            "COMPUTER_DIGITAL_CONTENT",
            "ECOMMERCE_SERVICES",
            "MAINTENANCE_AND_REPAIR_SERVICES",
            "MONITORS_AND_PROJECTORS",
            "NETWORKING",
            "ONLINE_GAMING",
            "PARTS_AND_ACCESSORIES",
            "PERIPHERALS",
            "SOFTWARE",
            "TRAINING_SERVICES",
            "WEB_HOSTING_AND_DESIGN",
            "BUSINESS_AND_SECRETARIAL_SCHOOLS",
            "CHILD_DAYCARE_SERVICES",
            "DANCE_HALLS_STUDIOS_AND_SCHOOLS",
            "VOCATIONAL_AND_TRADE_SCHOOLS",
            "CAMERAS_CAMCORDERS_AND_EQUIPMENT",
            "CELL_PHONES_PDAS_AND_PAGERS",
            "GENERAL_ELECTRONIC_ACCESSORIES",
            "HOME_AUDIO",
            "HOME_ELECTRONICS",
            "SECURITY_AND_SURVEILLANCE",
            "TELECOMMUNICATION_EQUIPMENT_AND_SALES",
            "TELECOMMUNICATION_SERVICES",
            "TELEPHONE_CARDS",
            "ENTERTAINMENT_MEMORABILIA",
            "MOVIE_TICKETS",
            "MOVIES_DVDS_VIDEOTAPES",
            "MUSIC_CDS_CASSETTES_AND_ALBUMS",
            "CABLE_SATELLITE_AND_OTHER_PAY_TV_AND_RADIO",
            "CONCERT_TICKETS",
            "THEATER_TICKETS",
            "TOYS_AND_GAMES",
            "ENTERTAINMENT_DIGITAL_CONTENT",
            "ENTERTAINERS",
            "ONLINE_GAMES",
            "VIDEO_GAMES_AND_SYSTEMS",
            "FINANCIAL_ACCOUNTING",
            "DEBT_COUNSELING_SERVICE",
            "FINANCIAL_AND_INVESTMENT_ADVICE",
            "REAL_ESTATE_AGENT",
            "RENTAL_PROPERTY_MANAGEMENT",
            "ALCOHOLIC_BEVERAGES",
            "CATERING_SERVICES",
            "COFFEE_AND_TEA",
            "GOURMET_FOODS",
            "SPECIALTY_AND_MISCELLANEOUS_FOOD_STORES",
            "RESTAURANT",
            "TOBACCO",
            "VITAMINS_AND_SUPPLEMENTS",
            "FLORIST",
            "GIFT_CARD_NOVELTY_AND_SOUVENIR_SHOPS",
            "GIFTS_GOURMET_FOODS",
            "NURSERY_PLANTS_AND_FLOWERS",
            "PARTY_SUPPLIES",
            "DENTAL_CARE",
            "MEDICAL_CARE",
            "MEDICAL_EQUIPMENT_AND_SUPPLIES",
            "VISION_CARE",
            "HEALTH_VITAMINS_AND_SUPPLEMENTS",
            "APPLIANCES",
            "HOME_ART_DEALERS_AND_GALLERIES",
            "BED_AND_BATH",
            "CONSTRUCTION_MATERIAL",
            "DRAPERY_WINDOW_COVERING_AND_UPHOLSTERY",
            "EXTERMINATING_AND_DISINFECTING_SERVICES",
            "FIREPLACE_AND_FIREPLACE_SCREENS",
            "HOME_FURNITURE",
            "GARDEN_SUPPLIES",
            "GLASS_PAINT_AND_WALLPAPER",
            "HARDWARE_AND_TOOLS",
            "HOME_DECOR",
            "HOUSEWARES",
            "KITCHENWARE",
            "LANDSCAPING",
            "RUGS_AND_CARPETS",
            "SECURITY_AND_SURVEILLANCE_EQUIPMENT",
            "SWIMMING_POOLS_AND_SPAS",
            "CHARITY",
            "POLITICAL",
            "RELIGIOUS",
            "OTHER",
            "PERSONAL",
            "EDUCATIONAL",
            "MEDICATION_AND_SUPPLEMENTS",
            "PET_SHOPS_PET_FOOD_AND_SUPPLIES",
            "SPECIALTY_OR_RARE_PETS",
            "VETERINARY_SERVICES",
            "MEMBERSHIP_SERVICES",
            "MERCHANDISE",
            "SERVICES_NOT_ELSEWHERE_CLASSIFIED",
            "RETAIL_CHEMICALS_AND_ALLIED_PRODUCTS",
            "DEPARTMENT_STORE",
            "DISCOUNT_STORE",
            "DURABLE_GOODS",
            "NONDURABLE_GOODS",
            "USED_AND_SECONDHAND_STORE",
            "VARIETY_STORE",
            "SERVICES_ADVERTISING",
            "SHOPPING_SERVICES_AND_BUYING_CLUBS",
            "CAREER_SERVICES",
            "CARPENTRY",
            "CHILD_CARE_SERVICES",
            "CLEANING_AND_MAINTENANCE",
            "COMMERCIAL_PHOTOGRAPHY",
            "SERVICES_COMPUTER_AND_DATA_PROCESSING_SERVICES",
            "COMPUTER_NETWORK_SERVICES",
            "SERVICES_CONSULTING_SERVICES",
            "COUNSELING_SERVICES",
            "COURIER_SERVICES",
            "SERVICES_DENTAL_CARE",
            "SERVICES_ECOMMERCE_SERVICES",
            "ELECTRICAL_AND_SMALL_APPLIANCE_REPAIR",
            "ENTERTAINMENT",
            "EQUIPMENT_RENTAL_AND_LEASING_SERVICES",
            "EVENT_AND_WEDDING_PLANNING",
            "GENERAL_CONTRACTORS",
            "GRAPHIC_AND_COMMERCIAL_DESIGN",
            "HEALTH_AND_BEAUTY_SPAS",
            "IDS_LICENSES_AND_PASSPORTS",
            "IMPORTING_AND_EXPORTING",
            "INFORMATION_RETRIEVAL_SERVICES",
            "LANDSCAPING_AND_HORTICULTURAL",
            "LEGAL_SERVICES_AND_ATTORNEYS",
            "LOCAL_DELIVERY_SERVICE",
            "SERVICES_MEDICAL_CARE",
            "MEMBERSHIP_CLUBS_AND_ORGANIZATIONS",
            "SERVICES_MISC_PUBLISHING_AND_PRINTING",
            "MOVING_AND_STORAGE",
            "PHOTOFINISHING",
            "PHOTOGRAPHIC_STUDIOS__PORTRAITS",
            "PROTECTIVE_AND_SECURITY_SERVICES",
            "SERVICES_QUICK_COPY_AND_REPRODUCTION_SERVICES",
            "RADIO_TELEVISION_AND_STEREO_REPAIR",
            "REAL_ESTATE_AGENT_",
            "SERVICES_RENTAL_PROPERTY_MANAGEMENT",
            "REUPHOLSTERY_AND_FURNITURE_REPAIR",
            "SERVICES_SERVICES_NOT_ELSEWHERE_CLASSIFIED",
            "SERVICES_SHIPPING_AND_PACKING",
            "SWIMMING_POOL_SERVICES",
            "TAILORS_AND_ALTERATIONS",
            "TELECOMMUNICATION_SERVICE",
            "UTILITIES",
            "SERVICES_VISION_CARE",
            "WATCH_CLOCK_AND_JEWELRY_REPAIR",
            "ATHLETIC_SHOES",
            "BICYCLE_SHOP_SERVICE_AND_REPAIR",
            "BOATING_SAILING_AND_ACCESSORIES",
            "CAMPING_AND_OUTDOORS",
            "SPORTS_DANCE_HALLS_STUDIOS_AND_SCHOOLS",
            "EXERCISE_AND_FITNESS",
            "FAN_GEAR_AND_MEMORABILIA",
            "HUNTING",
            "MARTIAL_ARTS_WEAPONS",
            "SPORT_GAMES_AND_TOYS",
            "SPORTING_EQUIPMENT",
            "SPORTS_SWIMMING_POOLS_AND_SPAS",
            "ARTS_AND_CRAFTS",
            "HOBBIES_CAMERA_AND_PHOTOGRAPHIC_SUPPLIES",
            "HOBBY_TOY_AND_GAME_SHOPS",
            "HOBBIES_MEMORABILIA",
            "MUSIC_STORE__INSTRUMENTS_AND_SHEET_MUSIC",
            "HOBBIES_STAMP_AND_COIN",
            "HOBBIES_STATIONARY_PRINTING_AND_WRITING_PAPER",
            "HOBBIES_VINTAGE_AND_COLLECTIBLES",
            "HOBBIES_VIDEO_GAMES_AND_SYSTEMS",
            "AIRLINE",
            "AUTO_RENTAL",
            "BUS_LINE",
            "CRUISES",
            "LODGING_AND_ACCOMMODATIONS",
            "LUGGAGE_AND_LEATHER_GOODS",
            "RECREATIONAL_SERVICES",
            "SPORTING_AND_RECREATION_CAMPS",
            "TAXICABS_AND_LIMOUSINES",
            "TIMESHARES",
            "TOURS",
            "TRAILER_PARKS_OR_CAMPGROUNDS",
            "TRANSPORTATION_SERVICES__OTHER",
            "TRAVEL_AGENCY",
            "NEW_PARTS_AND_SUPPLIES__MOTOR_VEHICLE",
            "USED_PARTS__MOTOR_VEHICLE",
            "AUDIO_AND_VIDEO",
            "AUTO_BODY_REPAIR_AND_PAINT",
            "SERVICES_AUTO_RENTAL",
            "AUTO_SERVICE",
            "AUTOMOTIVE_TIRE_SUPPLY_AND_SERVICE",
            "BOAT_RENTAL_AND_LEASES",
            "CAR_WASH",
            "MOTOR_HOME_AND_RECREATIONAL_VEHICLE_RENTAL",
            "TOOLS_AND_EQUIPMENT",
            "TOWING_SERVICE",
            "TRUCK_AND_UTILITY_TRAILER_RENTAL",
            "VEHICLE_ACCESSORIES",
            "ARCHITECT_STRUCTURAL_ENGINEER_OR_SURVEYOR",
            "ACCOUNTANCY_AND_BOOKKEEPING",
            "BUSINESS_SERVICES",
            "FINANCIAL_OR_INVESTMENT_ADVICE",
            "MORTGAGE_BROKERS",
            "SOFTWARE_AND_IT",
            "WEBSITE_DEVELOPMENT",
            "MANAGEMENT_CONSULTANCY",
            "PROJECT_MANAGEMENT",
            "MARKETING_ADVERTISING_AND_DESIGN",
            "GRAPHIC_DESIGN_AND_ILLUSTRATION",
            "INTERIOR_DESIGN",
            "RECRUITMENT_AND_HIRING",
            "LEGAL",
            "PHOTOGRAPHY",
            "SECURITY",
            "PROFESSIONAL_SERVICES_OTHER",
            "PERSONAL_TRAINER",
            "SPORTS_COACH",
            "SPORTS_CLUB",
            "SPORTS_AND_FITNESS_VENUE",
            "GYM_OPERATOR",
            "CLASS_INSTRUCTOR",
            "EXERCISE_AND_FITNESS_OTHER",
            "RESTAURANT_OR_CAFE",
            "TAKEAWAY",
            "STREET_FOOD_OR_MARKET_STALL",
            "RETAIL",
            "WHOLESALING",
            "SALONS",
            "AT_HOME_SERVICES",
            "LICENSED_RETAIL",
            "LICENSED_FOOD_VENUE",
            "RETAIL_BARS_AND_RESTAURANTS_OTHER",
            "DIGITAL_CONTENT_OR_GAMES",
            "PROMOTION_AND_PUBLISHING",
            "CATERING",
            "ENTERTAINERS_AND_DJS",
            "EVENTS_AND_WEDDINGS",
            "EVENTS_PRODUCTS",
            "EVENTS_STAFFING_AND_SERVICES",
            "TRAVEL_AGENT",
            "TOUR_GUIDE",
            "LODGING_AND_ACCOMMODATION",
            "TV_AND_RADIO",
            "MUSICIAN_OR_GROUPS",
            "ENTERTAINMENT_AND_TRAVEL_OTHER",
            "DOCTOR_NURSE_OR_MIDWIFE",
            "PHARMACY",
            "PERSONAL_AND_SOCIAL_CARE",
            "PHYSIOTHERAPIST",
            "NUTRITION_AND_DIET",
            "MENTAL_HEALTH_AND_COUNSELLING",
            "MEDICAL_EQUIPMENT_AND_SUPPLIERS",
            "DENTAL",
            "OPTICIAN",
            "OTHER_MEDICAL_THERAPY",
            "CHIROPRACTOR_OR_OSTEOPATH",
            "PODIATRIST",
            "COMPLIMENTARY_AND_ALTERNATIVE_MEDICINE",
            "HEALTH_AND_SOCIAL_CARE_OTHER",
            "HGV_OR_BUS_OR_COACH_DRIVER",
            "TAXI_OR_PRIVATE_HIRE_DRIVER",
            "TRAIN_DRIVER",
            "OTHER_PROFESSIONAL_DRIVER",
            "HOME_DELIVERY_AND_COURIER_FIRMS",
            "HAULAGE_FIRMS",
            "TAXI_OR_PRIVATE_HIRE_OPERATOR",
            "MINIBUS_OR_COACH_OPERATOR",
            "VEHICLE_REPAIR_AND_MAINTENANCE",
            "NEW_CARS_OR_VEHICLE_SALES",
            "VEHICLE_RENTAL",
            "BICYCLE_SHOPS",
            "USED_CAR_OR_VEHICLE_SALES",
            "VEHICLE_PARTS",
            "CAR_WASHING",
            "TRANSPORT_AND_VEHICLES_OTHER",
            "CLEANING",
            "DECORATING",
            "ELECTRICIAN",
            "PLUMBER",
            "GAS_AND_HEATING",
            "CARPENTRY_TRADE",
            "ROOFING",
            "GARDENING_AND_TREE_SURGERY",
            "GENERAL_CONTRACTOR",
            "CONSTRUCTION_SUPPLIER",
            "WASTE_AND_RECYCLING",
            "SITE_AND_BUILDING_MANAGEMENT",
            "CONSTRUCTION_TRADES_AND_CLEANING_OTHER",
            "PROPERTY_OWNER",
            "PROPERTY_INVESTOR",
            "PROPERTY_INVESTMENT_FUND",
            "RESIDENTS_ASSOCIATION",
            "LEASEHOLD_OR_FREEHOLD",
            "HOLIDAY_OR_SHORT_TERM_LETS",
            "PROPERTY_REDEVELOPMENT",
            "ESTATE_AGENT",
            "PROPERTY_MANAGEMENT",
            "STORAGE",
            "PROPERTY_OTHER",
            "PERSONAL_TUTOR",
            "MUSIC_TEACHERS",
            "PROFESSIONAL_TRAINER",
            "PUBLIC_SPEAKING",
            "NURSERY",
            "CHILDMINDER",
            "NANNY_OR_AU_PAIR",
            "CHILDRENS_ACTIVITIES",
            "STUDENT_RECRUITMENT",
            "SCHOOLS_COLLEGES_AND_TRAINING",
            "EDUCATION_AND_SKILLS_OTHER",
            "ANIMALS",
            "ARTS_CULTURE_AND_HUMANITIES",
            "COMMUNITY_DEVELOPMENT",
            "EDUCATION",
            "ENVIRONMENT",
            "HEALTH_AND_DISEASE",
            "HUMAN_AND_CIVIL_RIGHTS",
            "CHILDREN_YOUTH_AND_FAMILY",
            "HOMELESSNESS",
            "INTERNATIONAL",
            "RESEARCH_AND_PUBLIC_POLICY",
            "RELIGION",
            "NON_PROFIT_OTHER",
            "MANUFACTURING",
            "INDUSTRIAL_ENGINEER",
            "FOOD_OR_DRINK_PRODUCTION",
            "RESEARCH_AND_DEVELOPMENT",
            "LIVESTOCK_FARMING",
            "CROP_FARMING",
            "HORTICULTURE_OR_PLANT_NURSERY",
            "FORESTRY",
            "VETERINARY",
            "SUPPLIER_TO_AGRICULTURE_OR_INDUSTRY",
            "EQUESTRIAN",
            "ANIMAL_CARE",
            "MANUFACTURING_RND_AND_AGRICULTURE_OTHER"
        };

        /// <summary>
        /// Converts a BusinessSubCategory value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The BusinessSubCategory value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(BusinessSubCategory enumValue)
        {
            switch (enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case BusinessSubCategory.NOT_PROVIDED:
                case BusinessSubCategory.ART_AND_CRAFT_SUPPLIES:
                case BusinessSubCategory.ART_DEALERS_AND_GALLERIES:
                case BusinessSubCategory.CAMERA_AND_PHOTOGRAPHIC_SUPPLIES:
                case BusinessSubCategory.DIGITAL_ART:
                case BusinessSubCategory.MEMORABILIA:
                case BusinessSubCategory.MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC:
                case BusinessSubCategory.SEWING_NEEDLEWORK_AND_FABRICS:
                case BusinessSubCategory.STAMP_AND_COIN:
                case BusinessSubCategory.STATIONARY_PRINTING_AND_WRITING_PAPER:
                case BusinessSubCategory.VINTAGE_AND_COLLECTIBLES:
                case BusinessSubCategory.CLOTHING:
                case BusinessSubCategory.FURNITURE:
                case BusinessSubCategory.BABY_PRODUCTS_OTHER:
                case BusinessSubCategory.SAFETY_AND_HEALTH:
                case BusinessSubCategory.BATH_AND_BODY:
                case BusinessSubCategory.FRAGRANCES_AND_PERFUMES:
                case BusinessSubCategory.MAKEUP_AND_COSMETICS:
                case BusinessSubCategory.AUDIO_BOOKS:
                case BusinessSubCategory.DIGITAL_CONTENT:
                case BusinessSubCategory.EDUCATIONAL_AND_TEXTBOOKS:
                case BusinessSubCategory.FICTION_AND_NONFICTION:
                case BusinessSubCategory.MAGAZINES:
                case BusinessSubCategory.BOOKS_PUBLISHING_AND_PRINTING:
                case BusinessSubCategory.RARE_AND_USED_BOOKS:
                case BusinessSubCategory.ACCOUNTING:
                case BusinessSubCategory.ADVERTISING:
                case BusinessSubCategory.AGRICULTURAL:
                case BusinessSubCategory.ARCHITECTURAL_ENGINEERING_AND_SURVEYING_SERVICES:
                case BusinessSubCategory.CHEMICALS_AND_ALLIED_PRODUCTS:
                case BusinessSubCategory.COMMERCIAL_PHOTOGRAPHY_ART_AND_GRAPHICS:
                case BusinessSubCategory.CONSTRUCTION:
                case BusinessSubCategory.CONSULTING_SERVICES:
                case BusinessSubCategory.EDUCATIONAL_SERVICES:
                case BusinessSubCategory.EQUIPMENT_RENTALS_AND_LEASING_SERVICES:
                case BusinessSubCategory.EQUIPMENT_REPAIR_SERVICES:
                case BusinessSubCategory.HIRING_SERVICES:
                case BusinessSubCategory.INDUSTRIAL_AND_MANUFACTURING_SUPPLIES:
                case BusinessSubCategory.MAILING_LISTS:
                case BusinessSubCategory.MARKETING:
                case BusinessSubCategory.MULTILEVEL_MARKETING:
                case BusinessSubCategory.OFFICE_AND_COMMERCIAL_FURNITURE:
                case BusinessSubCategory.OFFICE_SUPPLIES_AND_EQUIPMENT:
                case BusinessSubCategory.PUBLISHING_AND_PRINTING:
                case BusinessSubCategory.QUICK_COPY_AND_REPRODUCTION_SERVICES:
                case BusinessSubCategory.SHIPPING_AND_PACKING:
                case BusinessSubCategory.STENOGRAPHIC_AND_SECRETARIAL_SUPPORT_SERVICES:
                case BusinessSubCategory.WHOLESALE:
                case BusinessSubCategory.CHILDRENS_CLOTHING:
                case BusinessSubCategory.MENS_CLOTHING:
                case BusinessSubCategory.WOMENS_CLOTHING:
                case BusinessSubCategory.SHOES:
                case BusinessSubCategory.MILITARY_AND_CIVIL_SERVICE_UNIFORMS:
                case BusinessSubCategory.ACCESSORIES:
                case BusinessSubCategory.RETAIL_FINE_JEWELRY_AND_WATCHES:
                case BusinessSubCategory.WHOLESALE_PRECIOUS_STONES_AND_METALS:
                case BusinessSubCategory.FASHION_JEWELLERY:
                case BusinessSubCategory.COMPUTER_AND_DATA_PROCESSING_SERVICES:
                case BusinessSubCategory.DESKTOPS_LAPTOPS_AND_NOTEBOOKS:
                case BusinessSubCategory.COMPUTER_DIGITAL_CONTENT:
                case BusinessSubCategory.ECOMMERCE_SERVICES:
                case BusinessSubCategory.MAINTENANCE_AND_REPAIR_SERVICES:
                case BusinessSubCategory.MONITORS_AND_PROJECTORS:
                case BusinessSubCategory.NETWORKING:
                case BusinessSubCategory.ONLINE_GAMING:
                case BusinessSubCategory.PARTS_AND_ACCESSORIES:
                case BusinessSubCategory.PERIPHERALS:
                case BusinessSubCategory.SOFTWARE:
                case BusinessSubCategory.TRAINING_SERVICES:
                case BusinessSubCategory.WEB_HOSTING_AND_DESIGN:
                case BusinessSubCategory.BUSINESS_AND_SECRETARIAL_SCHOOLS:
                case BusinessSubCategory.CHILD_DAYCARE_SERVICES:
                case BusinessSubCategory.DANCE_HALLS_STUDIOS_AND_SCHOOLS:
                case BusinessSubCategory.VOCATIONAL_AND_TRADE_SCHOOLS:
                case BusinessSubCategory.CAMERAS_CAMCORDERS_AND_EQUIPMENT:
                case BusinessSubCategory.CELL_PHONES_PDAS_AND_PAGERS:
                case BusinessSubCategory.GENERAL_ELECTRONIC_ACCESSORIES:
                case BusinessSubCategory.HOME_AUDIO:
                case BusinessSubCategory.HOME_ELECTRONICS:
                case BusinessSubCategory.SECURITY_AND_SURVEILLANCE:
                case BusinessSubCategory.TELECOMMUNICATION_EQUIPMENT_AND_SALES:
                case BusinessSubCategory.TELECOMMUNICATION_SERVICES:
                case BusinessSubCategory.TELEPHONE_CARDS:
                case BusinessSubCategory.ENTERTAINMENT_MEMORABILIA:
                case BusinessSubCategory.MOVIE_TICKETS:
                case BusinessSubCategory.MOVIES_DVDS_VIDEOTAPES:
                case BusinessSubCategory.MUSIC_CDS_CASSETTES_AND_ALBUMS:
                case BusinessSubCategory.CABLE_SATELLITE_AND_OTHER_PAY_TV_AND_RADIO:
                case BusinessSubCategory.CONCERT_TICKETS:
                case BusinessSubCategory.THEATER_TICKETS:
                case BusinessSubCategory.TOYS_AND_GAMES:
                case BusinessSubCategory.ENTERTAINMENT_DIGITAL_CONTENT:
                case BusinessSubCategory.ENTERTAINERS:
                case BusinessSubCategory.ONLINE_GAMES:
                case BusinessSubCategory.VIDEO_GAMES_AND_SYSTEMS:
                case BusinessSubCategory.FINANCIAL_ACCOUNTING:
                case BusinessSubCategory.DEBT_COUNSELING_SERVICE:
                case BusinessSubCategory.FINANCIAL_AND_INVESTMENT_ADVICE:
                case BusinessSubCategory.REAL_ESTATE_AGENT:
                case BusinessSubCategory.RENTAL_PROPERTY_MANAGEMENT:
                case BusinessSubCategory.ALCOHOLIC_BEVERAGES:
                case BusinessSubCategory.CATERING_SERVICES:
                case BusinessSubCategory.COFFEE_AND_TEA:
                case BusinessSubCategory.GOURMET_FOODS:
                case BusinessSubCategory.SPECIALTY_AND_MISCELLANEOUS_FOOD_STORES:
                case BusinessSubCategory.RESTAURANT:
                case BusinessSubCategory.TOBACCO:
                case BusinessSubCategory.VITAMINS_AND_SUPPLEMENTS:
                case BusinessSubCategory.FLORIST:
                case BusinessSubCategory.GIFT_CARD_NOVELTY_AND_SOUVENIR_SHOPS:
                case BusinessSubCategory.GIFTS_GOURMET_FOODS:
                case BusinessSubCategory.NURSERY_PLANTS_AND_FLOWERS:
                case BusinessSubCategory.PARTY_SUPPLIES:
                case BusinessSubCategory.DENTAL_CARE:
                case BusinessSubCategory.MEDICAL_CARE:
                case BusinessSubCategory.MEDICAL_EQUIPMENT_AND_SUPPLIES:
                case BusinessSubCategory.VISION_CARE:
                case BusinessSubCategory.HEALTH_VITAMINS_AND_SUPPLEMENTS:
                case BusinessSubCategory.APPLIANCES:
                case BusinessSubCategory.HOME_ART_DEALERS_AND_GALLERIES:
                case BusinessSubCategory.BED_AND_BATH:
                case BusinessSubCategory.CONSTRUCTION_MATERIAL:
                case BusinessSubCategory.DRAPERY_WINDOW_COVERING_AND_UPHOLSTERY:
                case BusinessSubCategory.EXTERMINATING_AND_DISINFECTING_SERVICES:
                case BusinessSubCategory.FIREPLACE_AND_FIREPLACE_SCREENS:
                case BusinessSubCategory.HOME_FURNITURE:
                case BusinessSubCategory.GARDEN_SUPPLIES:
                case BusinessSubCategory.GLASS_PAINT_AND_WALLPAPER:
                case BusinessSubCategory.HARDWARE_AND_TOOLS:
                case BusinessSubCategory.HOME_DECOR:
                case BusinessSubCategory.HOUSEWARES:
                case BusinessSubCategory.KITCHENWARE:
                case BusinessSubCategory.LANDSCAPING:
                case BusinessSubCategory.RUGS_AND_CARPETS:
                case BusinessSubCategory.SECURITY_AND_SURVEILLANCE_EQUIPMENT:
                case BusinessSubCategory.SWIMMING_POOLS_AND_SPAS:
                case BusinessSubCategory.CHARITY:
                case BusinessSubCategory.POLITICAL:
                case BusinessSubCategory.RELIGIOUS:
                case BusinessSubCategory.OTHER:
                case BusinessSubCategory.PERSONAL:
                case BusinessSubCategory.EDUCATIONAL:
                case BusinessSubCategory.MEDICATION_AND_SUPPLEMENTS:
                case BusinessSubCategory.PET_SHOPS_PET_FOOD_AND_SUPPLIES:
                case BusinessSubCategory.SPECIALTY_OR_RARE_PETS:
                case BusinessSubCategory.VETERINARY_SERVICES:
                case BusinessSubCategory.MEMBERSHIP_SERVICES:
                case BusinessSubCategory.MERCHANDISE:
                case BusinessSubCategory.SERVICES_NOT_ELSEWHERE_CLASSIFIED:
                case BusinessSubCategory.RETAIL_CHEMICALS_AND_ALLIED_PRODUCTS:
                case BusinessSubCategory.DEPARTMENT_STORE:
                case BusinessSubCategory.DISCOUNT_STORE:
                case BusinessSubCategory.DURABLE_GOODS:
                case BusinessSubCategory.NONDURABLE_GOODS:
                case BusinessSubCategory.USED_AND_SECONDHAND_STORE:
                case BusinessSubCategory.VARIETY_STORE:
                case BusinessSubCategory.SERVICES_ADVERTISING:
                case BusinessSubCategory.SHOPPING_SERVICES_AND_BUYING_CLUBS:
                case BusinessSubCategory.CAREER_SERVICES:
                case BusinessSubCategory.CARPENTRY:
                case BusinessSubCategory.CHILD_CARE_SERVICES:
                case BusinessSubCategory.CLEANING_AND_MAINTENANCE:
                case BusinessSubCategory.COMMERCIAL_PHOTOGRAPHY:
                case BusinessSubCategory.SERVICES_COMPUTER_AND_DATA_PROCESSING_SERVICES:
                case BusinessSubCategory.COMPUTER_NETWORK_SERVICES:
                case BusinessSubCategory.SERVICES_CONSULTING_SERVICES:
                case BusinessSubCategory.COUNSELING_SERVICES:
                case BusinessSubCategory.COURIER_SERVICES:
                case BusinessSubCategory.SERVICES_DENTAL_CARE:
                case BusinessSubCategory.SERVICES_ECOMMERCE_SERVICES:
                case BusinessSubCategory.ELECTRICAL_AND_SMALL_APPLIANCE_REPAIR:
                case BusinessSubCategory.ENTERTAINMENT:
                case BusinessSubCategory.EQUIPMENT_RENTAL_AND_LEASING_SERVICES:
                case BusinessSubCategory.EVENT_AND_WEDDING_PLANNING:
                case BusinessSubCategory.GENERAL_CONTRACTORS:
                case BusinessSubCategory.GRAPHIC_AND_COMMERCIAL_DESIGN:
                case BusinessSubCategory.HEALTH_AND_BEAUTY_SPAS:
                case BusinessSubCategory.IDS_LICENSES_AND_PASSPORTS:
                case BusinessSubCategory.IMPORTING_AND_EXPORTING:
                case BusinessSubCategory.INFORMATION_RETRIEVAL_SERVICES:
                case BusinessSubCategory.LANDSCAPING_AND_HORTICULTURAL:
                case BusinessSubCategory.LEGAL_SERVICES_AND_ATTORNEYS:
                case BusinessSubCategory.LOCAL_DELIVERY_SERVICE:
                case BusinessSubCategory.SERVICES_MEDICAL_CARE:
                case BusinessSubCategory.MEMBERSHIP_CLUBS_AND_ORGANIZATIONS:
                case BusinessSubCategory.SERVICES_MISC_PUBLISHING_AND_PRINTING:
                case BusinessSubCategory.MOVING_AND_STORAGE:
                case BusinessSubCategory.PHOTOFINISHING:
                case BusinessSubCategory.PHOTOGRAPHIC_STUDIOS_PORTRAITS:
                case BusinessSubCategory.PROTECTIVE_AND_SECURITY_SERVICES:
                case BusinessSubCategory.SERVICES_QUICK_COPY_AND_REPRODUCTION_SERVICES:
                case BusinessSubCategory.RADIO_TELEVISION_AND_STEREO_REPAIR:
                case BusinessSubCategory.REAL_ESTATE_AGENT_1:
                case BusinessSubCategory.SERVICES_RENTAL_PROPERTY_MANAGEMENT:
                case BusinessSubCategory.REUPHOLSTERY_AND_FURNITURE_REPAIR:
                case BusinessSubCategory.SERVICES_SERVICES_NOT_ELSEWHERE_CLASSIFIED:
                case BusinessSubCategory.SERVICES_SHIPPING_AND_PACKING:
                case BusinessSubCategory.SWIMMING_POOL_SERVICES:
                case BusinessSubCategory.TAILORS_AND_ALTERATIONS:
                case BusinessSubCategory.TELECOMMUNICATION_SERVICE:
                case BusinessSubCategory.UTILITIES:
                case BusinessSubCategory.SERVICES_VISION_CARE:
                case BusinessSubCategory.WATCH_CLOCK_AND_JEWELRY_REPAIR:
                case BusinessSubCategory.ATHLETIC_SHOES:
                case BusinessSubCategory.BICYCLE_SHOP_SERVICE_AND_REPAIR:
                case BusinessSubCategory.BOATING_SAILING_AND_ACCESSORIES:
                case BusinessSubCategory.CAMPING_AND_OUTDOORS:
                case BusinessSubCategory.SPORTS_DANCE_HALLS_STUDIOS_AND_SCHOOLS:
                case BusinessSubCategory.EXERCISE_AND_FITNESS:
                case BusinessSubCategory.FAN_GEAR_AND_MEMORABILIA:
                case BusinessSubCategory.HUNTING:
                case BusinessSubCategory.MARTIAL_ARTS_WEAPONS:
                case BusinessSubCategory.SPORT_GAMES_AND_TOYS:
                case BusinessSubCategory.SPORTING_EQUIPMENT:
                case BusinessSubCategory.SPORTS_SWIMMING_POOLS_AND_SPAS:
                case BusinessSubCategory.ARTS_AND_CRAFTS:
                case BusinessSubCategory.HOBBIES_CAMERA_AND_PHOTOGRAPHIC_SUPPLIES:
                case BusinessSubCategory.HOBBY_TOY_AND_GAME_SHOPS:
                case BusinessSubCategory.HOBBIES_MEMORABILIA:
                case BusinessSubCategory.MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC1:
                case BusinessSubCategory.HOBBIES_STAMP_AND_COIN:
                case BusinessSubCategory.HOBBIES_STATIONARY_PRINTING_AND_WRITING_PAPER:
                case BusinessSubCategory.HOBBIES_VINTAGE_AND_COLLECTIBLES:
                case BusinessSubCategory.HOBBIES_VIDEO_GAMES_AND_SYSTEMS:
                case BusinessSubCategory.AIRLINE:
                case BusinessSubCategory.AUTO_RENTAL:
                case BusinessSubCategory.BUS_LINE:
                case BusinessSubCategory.CRUISES:
                case BusinessSubCategory.LODGING_AND_ACCOMMODATIONS:
                case BusinessSubCategory.LUGGAGE_AND_LEATHER_GOODS:
                case BusinessSubCategory.RECREATIONAL_SERVICES:
                case BusinessSubCategory.SPORTING_AND_RECREATION_CAMPS:
                case BusinessSubCategory.TAXICABS_AND_LIMOUSINES:
                case BusinessSubCategory.TIMESHARES:
                case BusinessSubCategory.TOURS:
                case BusinessSubCategory.TRAILER_PARKS_OR_CAMPGROUNDS:
                case BusinessSubCategory.TRANSPORTATION_SERVICES_OTHER:
                case BusinessSubCategory.TRAVEL_AGENCY:
                case BusinessSubCategory.NEW_PARTS_AND_SUPPLIES_MOTOR_VEHICLE:
                case BusinessSubCategory.USED_PARTS_MOTOR_VEHICLE:
                case BusinessSubCategory.AUDIO_AND_VIDEO:
                case BusinessSubCategory.AUTO_BODY_REPAIR_AND_PAINT:
                case BusinessSubCategory.SERVICES_AUTO_RENTAL:
                case BusinessSubCategory.AUTO_SERVICE:
                case BusinessSubCategory.AUTOMOTIVE_TIRE_SUPPLY_AND_SERVICE:
                case BusinessSubCategory.BOAT_RENTAL_AND_LEASES:
                case BusinessSubCategory.CAR_WASH:
                case BusinessSubCategory.MOTOR_HOME_AND_RECREATIONAL_VEHICLE_RENTAL:
                case BusinessSubCategory.TOOLS_AND_EQUIPMENT:
                case BusinessSubCategory.TOWING_SERVICE:
                case BusinessSubCategory.TRUCK_AND_UTILITY_TRAILER_RENTAL:
                case BusinessSubCategory.VEHICLE_ACCESSORIES:
                case BusinessSubCategory.ARCHITECT_STRUCTURAL_ENGINEER_OR_SURVEYOR:
                case BusinessSubCategory.ACCOUNTANCY_AND_BOOKKEEPING:
                case BusinessSubCategory.BUSINESS_SERVICES:
                case BusinessSubCategory.FINANCIAL_OR_INVESTMENT_ADVICE:
                case BusinessSubCategory.MORTGAGE_BROKERS:
                case BusinessSubCategory.SOFTWARE_AND_IT:
                case BusinessSubCategory.WEBSITE_DEVELOPMENT:
                case BusinessSubCategory.MANAGEMENT_CONSULTANCY:
                case BusinessSubCategory.PROJECT_MANAGEMENT:
                case BusinessSubCategory.MARKETING_ADVERTISING_AND_DESIGN:
                case BusinessSubCategory.GRAPHIC_DESIGN_AND_ILLUSTRATION:
                case BusinessSubCategory.INTERIOR_DESIGN:
                case BusinessSubCategory.RECRUITMENT_AND_HIRING:
                case BusinessSubCategory.LEGAL:
                case BusinessSubCategory.PHOTOGRAPHY:
                case BusinessSubCategory.SECURITY:
                case BusinessSubCategory.PROFESSIONAL_SERVICES_OTHER:
                case BusinessSubCategory.PERSONAL_TRAINER:
                case BusinessSubCategory.SPORTS_COACH:
                case BusinessSubCategory.SPORTS_CLUB:
                case BusinessSubCategory.SPORTS_AND_FITNESS_VENUE:
                case BusinessSubCategory.GYM_OPERATOR:
                case BusinessSubCategory.CLASS_INSTRUCTOR:
                case BusinessSubCategory.EXERCISE_AND_FITNESS_OTHER:
                case BusinessSubCategory.RESTAURANT_OR_CAFE:
                case BusinessSubCategory.TAKEAWAY:
                case BusinessSubCategory.STREET_FOOD_OR_MARKET_STALL:
                case BusinessSubCategory.RETAIL:
                case BusinessSubCategory.WHOLESALING:
                case BusinessSubCategory.SALONS:
                case BusinessSubCategory.AT_HOME_SERVICES:
                case BusinessSubCategory.LICENSED_RETAIL:
                case BusinessSubCategory.LICENSED_FOOD_VENUE:
                case BusinessSubCategory.RETAIL_BARS_AND_RESTAURANTS_OTHER:
                case BusinessSubCategory.DIGITAL_CONTENT_OR_GAMES:
                case BusinessSubCategory.PROMOTION_AND_PUBLISHING:
                case BusinessSubCategory.CATERING:
                case BusinessSubCategory.ENTERTAINERS_AND_DJS:
                case BusinessSubCategory.EVENTS_AND_WEDDINGS:
                case BusinessSubCategory.EVENTS_PRODUCTS:
                case BusinessSubCategory.EVENTS_STAFFING_AND_SERVICES:
                case BusinessSubCategory.TRAVEL_AGENT:
                case BusinessSubCategory.TOUR_GUIDE:
                case BusinessSubCategory.LODGING_AND_ACCOMMODATION:
                case BusinessSubCategory.TV_AND_RADIO:
                case BusinessSubCategory.MUSICIAN_OR_GROUPS:
                case BusinessSubCategory.ENTERTAINMENT_AND_TRAVEL_OTHER:
                case BusinessSubCategory.DOCTOR_NURSE_OR_MIDWIFE:
                case BusinessSubCategory.PHARMACY:
                case BusinessSubCategory.PERSONAL_AND_SOCIAL_CARE:
                case BusinessSubCategory.PHYSIOTHERAPIST:
                case BusinessSubCategory.NUTRITION_AND_DIET:
                case BusinessSubCategory.MENTAL_HEALTH_AND_COUNSELLING:
                case BusinessSubCategory.MEDICAL_EQUIPMENT_AND_SUPPLIERS:
                case BusinessSubCategory.DENTAL:
                case BusinessSubCategory.OPTICIAN:
                case BusinessSubCategory.OTHER_MEDICAL_THERAPY:
                case BusinessSubCategory.CHIROPRACTOR_OR_OSTEOPATH:
                case BusinessSubCategory.PODIATRIST:
                case BusinessSubCategory.COMPLIMENTARY_AND_ALTERNATIVE_MEDICINE:
                case BusinessSubCategory.HEALTH_AND_SOCIAL_CARE_OTHER:
                case BusinessSubCategory.HGV_OR_BUS_OR_COACH_DRIVER:
                case BusinessSubCategory.TAXI_OR_PRIVATE_HIRE_DRIVER:
                case BusinessSubCategory.TRAIN_DRIVER:
                case BusinessSubCategory.OTHER_PROFESSIONAL_DRIVER:
                case BusinessSubCategory.HOME_DELIVERY_AND_COURIER_FIRMS:
                case BusinessSubCategory.HAULAGE_FIRMS:
                case BusinessSubCategory.TAXI_OR_PRIVATE_HIRE_OPERATOR:
                case BusinessSubCategory.MINIBUS_OR_COACH_OPERATOR:
                case BusinessSubCategory.VEHICLE_REPAIR_AND_MAINTENANCE:
                case BusinessSubCategory.NEW_CARS_OR_VEHICLE_SALES:
                case BusinessSubCategory.VEHICLE_RENTAL:
                case BusinessSubCategory.BICYCLE_SHOPS:
                case BusinessSubCategory.USED_CAR_OR_VEHICLE_SALES:
                case BusinessSubCategory.VEHICLE_PARTS:
                case BusinessSubCategory.CAR_WASHING:
                case BusinessSubCategory.TRANSPORT_AND_VEHICLES_OTHER:
                case BusinessSubCategory.CLEANING:
                case BusinessSubCategory.DECORATING:
                case BusinessSubCategory.ELECTRICIAN:
                case BusinessSubCategory.PLUMBER:
                case BusinessSubCategory.GAS_AND_HEATING:
                case BusinessSubCategory.CARPENTRY_TRADE:
                case BusinessSubCategory.ROOFING:
                case BusinessSubCategory.GARDENING_AND_TREE_SURGERY:
                case BusinessSubCategory.GENERAL_CONTRACTOR:
                case BusinessSubCategory.CONSTRUCTION_SUPPLIER:
                case BusinessSubCategory.WASTE_AND_RECYCLING:
                case BusinessSubCategory.SITE_AND_BUILDING_MANAGEMENT:
                case BusinessSubCategory.CONSTRUCTION_TRADES_AND_CLEANING_OTHER:
                case BusinessSubCategory.PROPERTY_OWNER:
                case BusinessSubCategory.PROPERTY_INVESTOR:
                case BusinessSubCategory.PROPERTY_INVESTMENT_FUND:
                case BusinessSubCategory.RESIDENTS_ASSOCIATION:
                case BusinessSubCategory.LEASEHOLD_OR_FREEHOLD:
                case BusinessSubCategory.HOLIDAY_OR_SHORT_TERM_LETS:
                case BusinessSubCategory.PROPERTY_REDEVELOPMENT:
                case BusinessSubCategory.ESTATE_AGENT:
                case BusinessSubCategory.PROPERTY_MANAGEMENT:
                case BusinessSubCategory.STORAGE:
                case BusinessSubCategory.PROPERTY_OTHER:
                case BusinessSubCategory.PERSONAL_TUTOR:
                case BusinessSubCategory.MUSIC_TEACHERS:
                case BusinessSubCategory.PROFESSIONAL_TRAINER:
                case BusinessSubCategory.PUBLIC_SPEAKING:
                case BusinessSubCategory.NURSERY:
                case BusinessSubCategory.CHILDMINDER:
                case BusinessSubCategory.NANNY_OR_AU_PAIR:
                case BusinessSubCategory.CHILDRENS_ACTIVITIES:
                case BusinessSubCategory.STUDENT_RECRUITMENT:
                case BusinessSubCategory.SCHOOLS_COLLEGES_AND_TRAINING:
                case BusinessSubCategory.EDUCATION_AND_SKILLS_OTHER:
                case BusinessSubCategory.ANIMALS:
                case BusinessSubCategory.ARTS_CULTURE_AND_HUMANITIES:
                case BusinessSubCategory.COMMUNITY_DEVELOPMENT:
                case BusinessSubCategory.EDUCATION:
                case BusinessSubCategory.ENVIRONMENT:
                case BusinessSubCategory.HEALTH_AND_DISEASE:
                case BusinessSubCategory.HUMAN_AND_CIVIL_RIGHTS:
                case BusinessSubCategory.CHILDREN_YOUTH_AND_FAMILY:
                case BusinessSubCategory.HOMELESSNESS:
                case BusinessSubCategory.INTERNATIONAL:
                case BusinessSubCategory.RESEARCH_AND_PUBLIC_POLICY:
                case BusinessSubCategory.RELIGION:
                case BusinessSubCategory.NON_PROFIT_OTHER:
                case BusinessSubCategory.MANUFACTURING:
                case BusinessSubCategory.INDUSTRIAL_ENGINEER:
                case BusinessSubCategory.FOOD_OR_DRINK_PRODUCTION:
                case BusinessSubCategory.RESEARCH_AND_DEVELOPMENT:
                case BusinessSubCategory.LIVESTOCK_FARMING:
                case BusinessSubCategory.CROP_FARMING:
                case BusinessSubCategory.HORTICULTURE_OR_PLANT_NURSERY:
                case BusinessSubCategory.FORESTRY:
                case BusinessSubCategory.VETERINARY:
                case BusinessSubCategory.SUPPLIER_TO_AGRICULTURE_OR_INDUSTRY:
                case BusinessSubCategory.EQUESTRIAN:
                case BusinessSubCategory.ANIMAL_CARE:
                case BusinessSubCategory.MANUFACTURING_RND_AND_AGRICULTURE_OTHER:
                    return StringValues[(int)enumValue];
                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of BusinessSubCategory values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of BusinessSubCategory values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<BusinessSubCategory> enumValues) => enumValues?.Select(ToValue).ToList();

        /// <summary>
        /// Converts a string value into BusinessSubCategory value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed BusinessSubCategory value</returns>
        /// <exception cref="InvalidCastException">Unable to cast value: {value} to type BusinessSubCategory</exception>
        public static BusinessSubCategory ParseString(string value)
        {
            var index = StringValues.IndexOf(value);
            if (index < 0)
                throw new InvalidCastException($"Unable to cast value: {value} to type BusinessSubCategory");
            return (BusinessSubCategory)index;
        }
    }
}
